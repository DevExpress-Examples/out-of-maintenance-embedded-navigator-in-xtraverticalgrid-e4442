using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraVerticalGrid;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraVerticalGrid.Internal;


namespace XtraVerticalGridNavigation {
    internal class MyVGridControl : VGridControl {
        private bool useEmbeddedNavigator;
        [Browsable(true),
        DefaultValue(false),
        Description("Gets or sets whether the embedded data navigator is visible.")]
        public bool UseEmbeddedNavigator {
            get {
                return useEmbeddedNavigator;
            }
            set {
                EmbeddedNavigator.Visible = value;
                useEmbeddedNavigator = value;
                 ((MyVGridScroller)Scroller).Invalidate();
            }
        }
        private ControlNavigator embeddedNavigator = new ControlNavigator();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ControlNavigator EmbeddedNavigator {
            get {
                return embeddedNavigator;
            }
            set {
                embeddedNavigator = value;
            }
        }
        public MyVGridControl()
            : base() {
            EmbeddedNavigator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            EmbeddedNavigator.TextLocation = NavigatorButtonsTextLocation.Center;
            EmbeddedNavigator.NavigatableControl = this;
            EmbeddedNavigator.Left = 1;
            Controls.Add(EmbeddedNavigator);
            EmbeddedNavigator.Hide();
        }

        protected override VGridScroller CreateScroller() {
            return new MyVGridScroller(this);
        }

        public class MyVGridScroller : VGridScroller {
            private MyVGridControl mygrid;
            public MyVGridScroller(VGridControlBase grid)
                : base(grid) {
                mygrid = (MyVGridControl)grid;
            }

            internal Rectangle ScrollSquare {
                get {
                    return new Rectangle(mygrid.ClientRectangle.Right - ScrollInfo.VScrollWidth, mygrid.ClientRectangle.Bottom - ScrollInfo.HScrollHeight, ScrollInfo.VScrollWidth, ScrollInfo.HScrollHeight);
                }
            }

            private Rectangle ScrollRect() {
                if (mygrid.UseEmbeddedNavigator) {
                    return GetScrollRectWithNavigator();
                } else {
                    return GetScrollRectWithoutNavigator();
                }
            }
            private Rectangle GetScrollRectWithNavigator() {
                return new Rectangle(1 + mygrid.EmbeddedNavigator.Width, 1, mygrid.Bounds.Width - 2 - mygrid.EmbeddedNavigator.Width + 15 - ScrollInfo.VScrollWidth, mygrid.Bounds.Height - ScrollInfo.HScrollHeight);
            }
            private Rectangle GetScrollRectWithoutNavigator() {
                return new Rectangle(mygrid.Bounds.Left + 1, mygrid.Bounds.Top + 1, mygrid.Bounds.Width - 2, mygrid.Bounds.Height - 20);
            }
            public void Invalidate() {
                Update();
            }
            public override void Update() {
                  try {
                    UpdateHScrollBar();
                    UpdateVScrollBar();                    
                    ScrollInfo.UpdateScrollerLocation(ScrollRect());
                    mygrid.ViewInfo.ViewRects.ScrollSquare = ScrollSquare;
                    if (mygrid.UseEmbeddedNavigator) {
                        mygrid.EmbeddedNavigator.Height = ScrollInfo.HScrollHeight - 1;
                        mygrid.EmbeddedNavigator.Top = mygrid.Bounds.Height - mygrid.EmbeddedNavigator.Height - 1;
                    }
                    var leftRecord = LeftVisibleRecord;
                    var topRowIndex = TopVisibleRowIndex;
                    LeftVisibleRecord = leftRecord;
                    TopVisibleRowIndex = topRowIndex;
                    if (leftRecord != LeftVisibleRecord || topRowIndex != TopVisibleRowIndex) {
                        mygrid.LayoutChanged();
                    }
                } finally {
                }
            }
            
        }
    }
}
