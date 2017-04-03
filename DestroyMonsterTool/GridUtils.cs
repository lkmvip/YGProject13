using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DestroyMonsterTool
{
      class GridUtils
      {
            public static void DeleteGridRow(DataGridView grid)
            {
                  try
                  {
                        foreach (DataGridViewRow row in grid.SelectedRows)
                        {
                              if (!row.IsNewRow)
                                    grid.Rows.Remove(row);

                        }

                  }
                  catch { }
            }

            public static void DataGridViewMoveUP(DataGridView dgv)
            {
                  int inIndex = dgv.CurrentRow.Index;

                  if (inIndex != 0)
                  {
                        DataGridViewRow dr = dgv.Rows[inIndex];
                        dgv.Rows.RemoveAt(inIndex);
                        dgv.Rows.Insert(inIndex - 1, dr);
                        dgv.CurrentCell = dgv.Rows[inIndex - 1].Cells[0];
                  }
            }

            public static void DataGridViewMoveDown(DataGridView dgv)
            {
                  int inIndex = dgv.CurrentRow.Index;
                  if (inIndex != (dgv.Rows.Count - 1))
                  {
                        DataGridViewRow dr = dgv.Rows[inIndex];
                        dgv.Rows.RemoveAt(inIndex);
                        dgv.Rows.Insert(inIndex + 1, dr);
                        dgv.CurrentCell = dgv.Rows[inIndex + 1].Cells[0];
                  }
            }
      }
}
