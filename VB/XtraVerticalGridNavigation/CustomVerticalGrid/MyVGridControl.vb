Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraVerticalGrid
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports DevExpress.XtraVerticalGrid.Internal


Namespace XtraVerticalGridNavigation
	Friend Class MyVGridControl
		Inherits VGridControl
		Private useEmbeddedNavigator_Renamed As Boolean
		<Browsable(True), DefaultValue(False), Description("Gets or sets whether the embedded data navigator is visible.")> _
		Public Property UseEmbeddedNavigator() As Boolean
			Get
				Return useEmbeddedNavigator_Renamed
			End Get
			Set(ByVal value As Boolean)
				EmbeddedNavigator.Visible = value
				useEmbeddedNavigator_Renamed = value
				 CType(Scroller, MyVGridScroller).Invalidate()
			End Set
		End Property
		Private embeddedNavigator_Renamed As New ControlNavigator()

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Property EmbeddedNavigator() As ControlNavigator
			Get
				Return embeddedNavigator_Renamed
			End Get
			Set(ByVal value As ControlNavigator)
				embeddedNavigator_Renamed = value
			End Set
		End Property
		Public Sub New()
			MyBase.New()
			EmbeddedNavigator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			EmbeddedNavigator.TextLocation = NavigatorButtonsTextLocation.Center
			EmbeddedNavigator.NavigatableControl = Me
			EmbeddedNavigator.Left = 1
			Controls.Add(EmbeddedNavigator)
			EmbeddedNavigator.Hide()
		End Sub

		Protected Overrides Function CreateScroller() As VGridScroller
			Return New MyVGridScroller(Me)
		End Function

		Public Class MyVGridScroller
			Inherits VGridScroller
			Private mygrid As MyVGridControl
			Public Sub New(ByVal grid As VGridControlBase)
				MyBase.New(grid)
				mygrid = CType(grid, MyVGridControl)
			End Sub

			Friend ReadOnly Property ScrollSquare() As Rectangle
				Get
					Return New Rectangle(mygrid.ClientRectangle.Right - ScrollInfo.VScrollWidth, mygrid.ClientRectangle.Bottom - ScrollInfo.HScrollHeight, ScrollInfo.VScrollWidth, ScrollInfo.HScrollHeight)
				End Get
			End Property

			Private Function ScrollRect() As Rectangle
				If mygrid.UseEmbeddedNavigator Then
					Return GetScrollRectWithNavigator()
				Else
					Return GetScrollRectWithoutNavigator()
				End If
			End Function
			Private Function GetScrollRectWithNavigator() As Rectangle
				Return New Rectangle(1 + mygrid.EmbeddedNavigator.Width, 1, mygrid.Bounds.Width - 2 - mygrid.EmbeddedNavigator.Width + 15 - ScrollInfo.VScrollWidth, mygrid.Bounds.Height - ScrollInfo.HScrollHeight)
			End Function
			Private Function GetScrollRectWithoutNavigator() As Rectangle
				Return New Rectangle(mygrid.Bounds.Left + 1, mygrid.Bounds.Top + 1, mygrid.Bounds.Width - 2, mygrid.Bounds.Height - 20)
			End Function
			Public Sub Invalidate()
				Update()
			End Sub
			Public Overrides Sub Update()
				  Try
					UpdateHScrollBar()
					UpdateVScrollBar()
					ScrollInfo.UpdateScrollerLocation(ScrollRect())
					mygrid.ViewInfo.ViewRects.ScrollSquare = ScrollSquare
					If mygrid.UseEmbeddedNavigator Then
						mygrid.EmbeddedNavigator.Height = ScrollInfo.HScrollHeight - 1
						mygrid.EmbeddedNavigator.Top = mygrid.Bounds.Height - mygrid.EmbeddedNavigator.Height - 1
					End If
					Dim leftRecord = LeftVisibleRecord
					Dim topRowIndex = TopVisibleRowIndex
					LeftVisibleRecord = leftRecord
					TopVisibleRowIndex = topRowIndex
                    If leftRecord <> LeftVisibleRecord OrElse topRowIndex <> TopVisibleRowIndex Then
                        mygrid.LayoutChanged()
                    End If
				Finally
				End Try
			End Sub

		End Class
	End Class
End Namespace
