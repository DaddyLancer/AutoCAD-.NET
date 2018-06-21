Imports Autodesk.AutoCAD
Imports Autodesk.AutoCAD.Interop
Imports Autodesk.AutoCAD.Interop.Common
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Colors

Public Class Class1
    Dim CAD As New CADFunctions
    Dim ed As Editor = Core.Application.DocumentManager.MdiActiveDocument.Editor
    Dim curSelection As SelectionSet
    Dim sr As PromptSelectionResult = ed.SelectImplied()

    'Enable referencing the active window as "ThisDrawing" throughout the code.
    Public ReadOnly Property ThisDrawing As AcadDocument
        Get
            Return DocumentExtension.GetAcadDocument(Core.Application.DocumentManager.MdiActiveDocument)
        End Get
    End Property

#Region "ACAD"
    'Enable the use of command MBORD to call the subroutine "CreateMTextBorder"
    <CommandMethod("MBORD")>
    Public Sub CreateMTextBorder()
        Dim ent As AcadEntity 'The Text entity
        Dim pnt As Object 'The coordinate list or "PickedPoints" 
        Try
            ThisDrawing.Utility.GetEntity(ent, pnt, "Vælg en MText") 'Try to retrieve the text entity and coordinates by prompting user selection.
            Dim mt As IAcadMText = ent
            Dim boundMin, boundMax As Object
            Dim coords(7) As Double
            mt.GetBoundingBox(boundMin, boundMax)
            '0-1 = Bottom Left Corner      2-3 = Bottom Right Corner       4-5 = Top Right Corner      6-7 = Top Left Corner
            coords(0) = boundMin(0) - 1
            coords(1) = boundMin(1) - 1
            coords(2) = boundMax(0) + 1
            coords(3) = boundMin(1) - 1
            coords(4) = boundMax(0) + 1
            coords(5) = boundMax(1) + 1
            coords(6) = boundMin(0) - 1
            coords(7) = boundMax(1) + 1

            'Draw the border in it's appropiate space.
            If ThisDrawing.ActiveSpace = AcActiveSpace.acModelSpace Then
                ThisDrawing.ModelSpace.AddLightWeightPolyline(coords).Closed = True
            Else
                ThisDrawing.PaperSpace.AddLightWeightPolyline(coords).Closed = True
            End If
        Catch ex As Exception
            ThisDrawing.Utility.Prompt("Ugyldigt valg.")
        End Try
    End Sub

    <CommandMethod("GridAlign", CommandFlags.Redraw + CommandFlags.UsePickSet)>
    Public Sub GridAlign()
        If sr.Status = PromptStatus.OK Then
            curSelection = sr.Value
        End If
    End Sub

    <CommandMethod("StartPID", CommandFlags.NoPaperSpace + CommandFlags.NoPerspective)>
    Public Sub PIDSetup()
        Application.DocumentManager.MdiActiveDocument.Database.Orthomode = True
        Application.SetSystemVariable("SNAPMODE", 1)
        Application.SetSystemVariable("GRIDUNIT", 0.5)
    End Sub

    <CommandMethod("PFT", CommandFlags.UsePickSet + CommandFlags.Redraw + CommandFlags.Modal)>
    Public Sub ToggleGrouping()

        Dim curObjs As ObjectIdCollection
        Dim arObjIds() As ObjectId

        If (sr.Status = PromptStatus.OK) Then
            curSelection = sr.Value
            curObjs = New ObjectIdCollection(sr.Value.GetObjectIds())
            ed.WriteMessage("Antal objekter valgt: " & sr.Value.Count.ToString())
        Else
            curObjs = New ObjectIdCollection()
            ed.WriteMessage("Vælg nogle objekter")
            sr = ed.GetSelection()
            If (sr.Status = PromptStatus.OK) Then
                ed.WriteMessage("Antal nye objekter valgt: " & sr.Value.Count.ToString())
                For Each objId As ObjectId In sr.Value.GetObjectIds()
                    curObjs.Add(objId)
                Next
                curObjs.CopyTo(arObjIds, 0)
                'ed.SetImpliedSelection(tSelectionSet)
                For Each obj As ObjectId In curObjs
                    Debug.WriteLine(obj.ToString())
                Next

            End If
        End If
    End Sub

    <CommandMethod("tGroup", CommandFlags.UsePickSet + CommandFlags.Modal + CommandFlags.Redraw)>
    Public Sub tGroup()
        Dim sObjs As ObjectIdCollection
        Dim grp As Group = New Group("", True)

        If sr.Status = PromptStatus.OK Then
            curSelection = sr.Value
            sObjs = New ObjectIdCollection(sr.Value.GetObjectIds())


        Else
            ed.WriteMessage("You must have some objects, or a group selected before toggle grouping.")
        End If

    End Sub
#End Region

#Region "Plant 3D"

    <CommandMethod("BatchACADExport")>
    Public Sub BatchACADExport()
        Dim ExportForm As New frmAcadExport
        ExportForm.Show()
    End Sub


#End Region
End Class
