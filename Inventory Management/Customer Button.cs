using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class CustomerButton : UserControl
    {
        public CustomerButton()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }
        public Image ImageHover
        {
            get { return HoverImage; }
            set {  NormalImage = value; }

        }

        public Image Image { get; private set; }

        private void Customer_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void Customer_Button_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
