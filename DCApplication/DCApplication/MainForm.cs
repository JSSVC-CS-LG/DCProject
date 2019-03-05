using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCApplication
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            
            TileGroup group = new TileGroup();
            group.Text = "New";

            TileItem item = new TileItem();
            item.Text = "1";
            group.Items.Add(item);

            this.tileControl1.Groups.Add(group);
        }


        private void logoutButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();           
        }
    }
}
