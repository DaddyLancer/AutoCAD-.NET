Class CADFunctions
    Function PickPoint(Msg As String) As Autodesk.AutoCAD.Geometry.Point3d
        Dim myDoc As Autodesk.AutoCAD.ApplicationServices.Document
        myDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim myEditor As Autodesk.AutoCAD.EditorInput.Editor = myDoc.Editor
        Dim myPPR As Autodesk.AutoCAD.EditorInput.PromptPointResult
        myPPR = myEditor.GetPoint(Msg)
        If myPPR.Status = Autodesk.AutoCAD.EditorInput.PromptStatus.OK Then
            Return myPPR.Value
        Else
            Return Nothing
        End If
    End Function

    Function PickPoint(Msg As String, BasePoint As Autodesk.AutoCAD.Geometry.Point3d) As Autodesk.AutoCAD.Geometry.Point3d
        Dim myDoc As Autodesk.AutoCAD.ApplicationServices.Document
        myDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim myEditor As Autodesk.AutoCAD.EditorInput.Editor = myDoc.Editor
        Dim myPPO As New Autodesk.AutoCAD.EditorInput.PromptPointOptions(Msg)
        myPPO.BasePoint = BasePoint
        myPPO.UseBasePoint = True
        Dim myPPR As Autodesk.AutoCAD.EditorInput.PromptPointResult
        myPPR = myEditor.GetPoint(myPPO)
        If myPPR.Status = Autodesk.AutoCAD.EditorInput.PromptStatus.OK Then
            Return myPPR.Value
        Else
            Return Nothing
        End If
    End Function

    Function DrawLine(dbIn As Autodesk.AutoCAD.DatabaseServices.Database,
        X1 As Double, Y1 As Double, Z1 As Double, X2 As Double, Y2 As Double, Z2 As Double) _
        As Autodesk.AutoCAD.DatabaseServices.ObjectId

        Using myTrans As Autodesk.AutoCAD.DatabaseServices.Transaction = dbIn.TransactionManager.StartTransaction
            Dim myBTR As Autodesk.AutoCAD.DatabaseServices.BlockTableRecord =
                dbIn.CurrentSpaceId.GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)
            Dim stPt As New Autodesk.AutoCAD.Geometry.Point3d(X1, Y1, Z1)
            Dim enPt As New Autodesk.AutoCAD.Geometry.Point3d(X2, Y2, Z2)
            Dim newLine As New Autodesk.AutoCAD.DatabaseServices.Line(stPt, enPt)
            myBTR.AppendEntity(newLine)
            myTrans.AddNewlyCreatedDBObject(newLine, True)
            myTrans.Commit()
            Return newLine.ObjectId
        End Using
    End Function

    Function PickEntity(Msg As String) As Autodesk.AutoCAD.DatabaseServices.ObjectId
        Dim myDoc As Autodesk.AutoCAD.ApplicationServices.Document
        myDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim myEditor As Autodesk.AutoCAD.EditorInput.Editor = myDoc.Editor
        Dim myPEO As New Autodesk.AutoCAD.EditorInput.PromptEntityOptions(Msg)
        Dim myPER As Autodesk.AutoCAD.EditorInput.PromptEntityResult
        myPER = myEditor.GetEntity(myPEO)
        If myPER.Status = Autodesk.AutoCAD.EditorInput.PromptStatus.OK Then
            Return myPER.ObjectId
        Else
            Return Nothing
        End If
    End Function

    Function SelectBlocksOnScreen() As Autodesk.AutoCAD.DatabaseServices.ObjectId()
        Dim myDoc As Autodesk.AutoCAD.ApplicationServices.Document
        myDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim myEditor As Autodesk.AutoCAD.EditorInput.Editor = myDoc.Editor
        Dim myTVs(0) As Autodesk.AutoCAD.DatabaseServices.TypedValue
        myTVs(0) = New Autodesk.AutoCAD.DatabaseServices.TypedValue(0, "INSERT")
        Dim myFilter As New Autodesk.AutoCAD.EditorInput.SelectionFilter(myTVs)
        Dim myPSR As Autodesk.AutoCAD.EditorInput.PromptSelectionResult
        myPSR = myEditor.GetSelection(myFilter)
        If myPSR.Status = Autodesk.AutoCAD.EditorInput.PromptStatus.OK Then
            Return myPSR.Value.GetObjectIds
        Else
            Return Nothing
        End If
    End Function

    Function SelectAllBlocks() As Autodesk.AutoCAD.DatabaseServices.ObjectId()
        Dim myDoc As Autodesk.AutoCAD.ApplicationServices.Document
        myDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim myEditor As Autodesk.AutoCAD.EditorInput.Editor = myDoc.Editor
        Dim myTVs(0) As Autodesk.AutoCAD.DatabaseServices.TypedValue
        myTVs(0) = New Autodesk.AutoCAD.DatabaseServices.TypedValue(0, "INSERT")
        Dim myFilter As New Autodesk.AutoCAD.EditorInput.SelectionFilter(myTVs)
        Dim myPSR As Autodesk.AutoCAD.EditorInput.PromptSelectionResult
        myPSR = myEditor.SelectAll(myFilter)
        If myPSR.Status = Autodesk.AutoCAD.EditorInput.PromptStatus.OK Then
            Return myPSR.Value.GetObjectIds
        Else
            Return Nothing
        End If
    End Function

    Function GetBlockAttributes(BlockID As Autodesk.AutoCAD.DatabaseServices.ObjectId) As Dictionary(Of String, String)
        Dim myD As New Dictionary(Of String, String)
        Using myTrans As Autodesk.AutoCAD.DatabaseServices.Transaction =
                BlockID.Database.TransactionManager.StartTransaction()
            Dim myBlockRef As Autodesk.AutoCAD.DatabaseServices.BlockReference =
                BlockID.GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
            If myBlockRef.AttributeCollection.Count > 0 Then
                For Each myAttRefID As Autodesk.AutoCAD.DatabaseServices.ObjectId In myBlockRef.AttributeCollection
                    Dim myAttRef As Autodesk.AutoCAD.DatabaseServices.AttributeReference = myAttRefID.GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
                    If myD.ContainsKey(myAttRef.Tag) = False Then
                        myD.Add(myAttRef.Tag, myAttRef.TextString)
                    End If
                Next
            End If
            myTrans.Dispose()
        End Using
        Return myD
    End Function

    Function GetBlockProperties(ObjID As Autodesk.AutoCAD.DatabaseServices.ObjectId) As Dictionary(Of String, Object)
        Dim myD As New Dictionary(Of String, Object)
        Using myTrans As Autodesk.AutoCAD.DatabaseServices.Transaction =
                ObjID.Database.TransactionManager.StartTransaction
            Dim myEnt As Autodesk.AutoCAD.DatabaseServices.BlockReference =
                ObjID.GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
            For Each myPInfo As System.Reflection.PropertyInfo In GetType(Autodesk.AutoCAD.DatabaseServices.BlockReference).GetProperties
                myD.Add(myPInfo.Name, myPInfo.GetValue(myEnt))
            Next
        End Using
        Return myD
    End Function

    Function GetBTRProperties(ObjID As Autodesk.AutoCAD.DatabaseServices.ObjectId) As Dictionary(Of String, Object)
        Dim myD As New Dictionary(Of String, Object)
        Using myTrans As Autodesk.AutoCAD.DatabaseServices.Transaction =
                ObjID.Database.TransactionManager.StartTransaction
            Dim myEnt As Autodesk.AutoCAD.DatabaseServices.BlockTableRecord =
                ObjID.GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
            For Each myPInfo As System.Reflection.PropertyInfo In GetType(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord).GetProperties
                myD.Add(myPInfo.Name, myPInfo.GetValue(myEnt))
            Next
        End Using
        Return myD
    End Function

    Sub WriteToTextFile(TextToWrite As String, FilePath As String)
        Dim mySW As New IO.StreamWriter(FilePath)
        mySW.WriteLine(TextToWrite)
        mySW.Close()
        mySW.Dispose()
    End Sub

    Sub AppendToTextFile(TextToWrite As String, FilePath As String)
        Dim mySW As New IO.StreamWriter(FilePath, True)
        mySW.WriteLine(TextToWrite)
        mySW.Close()
        mySW.Dispose()
    End Sub
End Class
