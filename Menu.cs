using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SVPfract
{
    public partial class SPVfractForm : Form
    {

        private void copyItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);


            // create a memory stream to save the chart image    
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            // save the chart image to the stream    
            cht.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp);

            // create a bitmap using the stream    
            Bitmap bmp = new Bitmap(stream);

            // save the bitmap to the clipboard    
            Clipboard.SetDataObject(bmp);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // Sets the current file name filter string, which determines 
            // the choices that appear in the "Save as file type" or 
            // "Files of type" box in the dialog box.
            saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            // Set image file format
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ChartImageFormat format = ChartImageFormat.Bmp;

                if (saveFileDialog1.FileName.EndsWith("bmp")) format = ChartImageFormat.Bmp;
                else if (saveFileDialog1.FileName.EndsWith("jpg")) format = ChartImageFormat.Jpeg;
                else if (saveFileDialog1.FileName.EndsWith("emf")) format = ChartImageFormat.Emf;
                else if (saveFileDialog1.FileName.EndsWith("gif")) format = ChartImageFormat.Gif;
                else if (saveFileDialog1.FileName.EndsWith("png")) format = ChartImageFormat.Png;
                else if (saveFileDialog1.FileName.EndsWith("tif")) format = ChartImageFormat.Tiff;

                // Save image
                cht.SaveImage(saveFileDialog1.FileName, format);

            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);
            cht.Printing.PrintPreview();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);
            cht.Printing.Print(true);

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
    }
}