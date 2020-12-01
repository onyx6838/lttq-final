using System;
using System.Data;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Handling
{
    public class ExcelAutomate
    {
        public static void automateEx(DataGridView dgvInfo, string nameHD)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            /*-------*/
            exRange = exSheet.Cells[1, 1];
            exSheet.Columns[5].ColumnWidth = 18;
            exRange.Range["A1:Z300"].Font.Name = "Times New Roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Vinmart C#";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Láng Thượng - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0123456789";
            exRange.Range["C5:E5"].Font.Size = 16;
            exRange.Range["C5:E5"].Font.Bold = true;
            exRange.Range["C5:E5"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C5:E5"].MergeCells = true;
            exRange.Range["C5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:E5"].Value = nameHD;

            /*exRange.Range["A:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;*/

            for (int i = 1; i < dgvInfo.Columns.Count + 1; i++)
            {
                exSheet.Cells[7, i + 0] = dgvInfo.Columns[i - 1].HeaderText;
                exSheet.Cells[7, i + 0].Borders.LineStyle = 1;
            }

            for (int i = 0; i < dgvInfo.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvInfo.Columns.Count; j++)
                {
                    exSheet.Cells[i + 8, j + 1] = dgvInfo.Rows[i].Cells[j].Value.ToString();
                    exSheet.Cells[i + 8, j + 1].Borders.LineStyle = 1;
                }
            }
            exApp.Visible = true;
            exBook.Close();
            exApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
        }

        public static void automateHD(DataTable hd, DataTable cthd, string nameHD, string objHD)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            /*-------*/
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times New Roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Vinmart C#";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Láng Thượng - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0123456789";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = nameHD;
            // Biểu diễn thông tin chung của hóa đơn bán
            tblThongtinHD = hd;
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = objHD;
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng

            tblThongtinHang = cthd;
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["A11:A11"].Borders.LineStyle = 1;
            exRange.Range["B11:B11"].Value = "Tên Hàng";
            exRange.Range["C11:C11"].Value = "Số Lượng";
            exRange.Range["D11:D11"].Value = "Đơn Giá";
            exRange.Range["E11:E11"].Value = "Giảm Giá";
            exRange.Range["F11:F11"].Value = "Thành Tiền";
            exRange.Range["A11:F11"].Borders.LineStyle = 1;
            if (tblThongtinHang.Rows.Count == 0)
            {
                exRange.Range["E14:E14"].Font.Bold = true;
                exRange.Range["E14:E14"].Value2 = "Tổng Tiền:";
                exRange = exSheet.Cells[cot + 6][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
                exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
                exRange.Range["A1:F1"].MergeCells = true;
                exRange.Range["A1:F1"].Font.Bold = true;
                exRange.Range["A1:F1"].Font.Italic = true;
                exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
                string r = tblThongtinHD.Rows[0][2].ToString();
                double rchu = double.Parse(r);
                exRange.Range["A1:F1"].Value = "Bằng Chữ: " + FormHandling.ChuyenSoSangChuoi(rchu);
                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
                exRange.Range["A1:C1"].Value = "Hà Nội, Ngày " + d.Day + " Tháng " + d.Month + " Năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân Viên Bán Hàng";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;
                exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
               
                exSheet.Name = nameHD;
                exApp.Visible = true;
                exBook.Close();
                exApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
            }
            else
            {
                for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 12] = hang + 1;
                    for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12 
                    {
                        exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                        // hang 0 nhưng cột tăng dần để điền thêm thông tin hàng
                        exSheet.Cells[cot + 2][hang + 12].Borders.LineStyle = 1;
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                    }
                }
                exRange = exSheet.Cells[cot][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = "Tổng Tiền:";
                exRange = exSheet.Cells[cot + 1][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
                exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
                exRange.Range["A1:F1"].MergeCells = true;
                exRange.Range["A1:F1"].Font.Bold = true;
                exRange.Range["A1:F1"].Font.Italic = true;
                exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
                string r = tblThongtinHD.Rows[0][2].ToString();
                double rchu = double.Parse(r);
                exRange.Range["A1:F1"].Value = "Bằng Chữ: " + FormHandling.ChuyenSoSangChuoi(rchu);
                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
                exRange.Range["A1:C1"].Value = "Hà Nội, Ngày " + d.Day + " Tháng " + d.Month + " Năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân Viên Bán Hàng";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;
                exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
                exSheet.Name = nameHD;
                exApp.Visible = true;
                exBook.Close();
                exApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
            }
        }
    }
}
