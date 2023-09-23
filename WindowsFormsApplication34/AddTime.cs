/*
* Copyright (c) 2010, Демченко Сергей Сергеевич, doctor.dss@mail.ru
*
* Разрешается повторное распространение и использование как в виде исходного
* кода, так и в двоичной форме, с изменениями или без, при соблюдении
* следующих условий:
*
*     * При повторном распространении исходного кода должно оставаться
*       указанное выше уведомление об авторском праве, этот список условий и
*       последующий отказ от гарантий.
*     * При повторном распространении двоичного кода должна сохраняться
*       указанная выше информация об авторском праве, этот список условий и
*       последующий отказ от гарантий в документации и/или в других
*       материалах, поставляемых при распространении.
*
* ЭТА ПРОГРАММА ПРЕДОСТАВЛЕНА ВЛАДЕЛЬЦАМИ АВТОРСКИХ ПРАВ И/ИЛИ ДРУГИМИ
* СТОРОНАМИ "КАК ОНА ЕСТЬ" БЕЗ КАКОГО-ЛИБО ВИДА ГАРАНТИЙ, ВЫРАЖЕННЫХ ЯВНО
* ИЛИ ПОДРАЗУМЕВАЕМЫХ, ВКЛЮЧАЯ, НО НЕ ОГРАНИЧИВАЯСЬ ИМИ, ПОДРАЗУМЕВАЕМЫЕ
* ГАРАНТИИ КОММЕРЧЕСКОЙ ЦЕННОСТИ И ПРИГОДНОСТИ ДЛЯ КОНКРЕТНОЙ ЦЕЛИ. НИ В
* КОЕМ СЛУЧАЕ, ЕСЛИ НЕ ТРЕБУЕТСЯ СООТВЕТСТВУЮЩИМ ЗАКОНОМ, ИЛИ НЕ УСТАНОВЛЕНО
* В УСТНОЙ ФОРМЕ, НИ ОДИН ВЛАДЕЛЕЦ АВТОРСКИХ ПРАВ И НИ ОДНО  ДРУГОЕ ЛИЦО,
* КОТОРОЕ МОЖЕТ ИЗМЕНЯТЬ И/ИЛИ ПОВТОРНО РАСПРОСТРАНЯТЬ ПРОГРАММУ, КАК БЫЛО
* СКАЗАНО ВЫШЕ, НЕ НЕСЁТ ОТВЕТСТВЕННОСТИ, ВКЛЮЧАЯ ЛЮБЫЕ ОБЩИЕ, СЛУЧАЙНЫЕ,
* СПЕЦИАЛЬНЫЕ ИЛИ ПОСЛЕДОВАВШИЕ УБЫТКИ, ВСЛЕДСТВИЕ ИСПОЛЬЗОВАНИЯ ИЛИ
* НЕВОЗМОЖНОСТИ ИСПОЛЬЗОВАНИЯ ПРОГРАММЫ (ВКЛЮЧАЯ, НО НЕ ОГРАНИЧИВАЯСЬ
* ПОТЕРЕЙ ДАННЫХ, ИЛИ ДАННЫМИ, СТАВШИМИ НЕПРАВИЛЬНЫМИ, ИЛИ ПОТЕРЯМИ
* ПРИНЕСЕННЫМИ ИЗ-ЗА ВАС ИЛИ ТРЕТЬИХ ЛИЦ, ИЛИ ОТКАЗОМ ПРОГРАММЫ РАБОТАТЬ
* СОВМЕСТНО С ДРУГИМИ ПРОГРАММАМИ), ДАЖЕ ЕСЛИ ТАКОЙ ВЛАДЕЛЕЦ ИЛИ ДРУГОЕ
* ЛИЦО БЫЛИ ИЗВЕЩЕНЫ О ВОЗМОЖНОСТИ ТАКИХ УБЫТКОВ.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSS
{
    public partial class AddTime : Form
    {
        public AddTime()
        {
            InitializeComponent();
        }



        public DateTime beginTime = DateTime.Today;
        public DateTime endTime = DateTime.Today;


        private void AddTime_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.MaxDate = beginTime;
            dateTimePicker1.MinDate = beginTime.Date;
            dateTimePicker2.Value = dateTimePicker2.MinDate = endTime;
            dateTimePicker2.MaxDate = endTime.Date.AddDays(1).AddMinutes(-1);
            numericUpDown1.Maximum = beginTime.Minute + beginTime.Hour * 60;
            numericUpDown2.Maximum = 1439 - (endTime.Minute + endTime.Hour * 60);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Focused)
            {
                dateTimePicker1.Value = beginTime.AddMinutes(-(int)numericUpDown1.Value);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Focused)
            {
                dateTimePicker2.Value = endTime.AddMinutes((int)numericUpDown2.Value);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Focused)
            {
                numericUpDown1.Value = (int)(beginTime.TimeOfDay - dateTimePicker1.Value.TimeOfDay).TotalMinutes;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Focused)
            {
                numericUpDown2.Value = (int)(dateTimePicker2.Value.TimeOfDay - endTime.TimeOfDay).TotalMinutes;
            }
        }

        private void AddTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            ((ZapisZur)this.Tag).addedPeriodToBegin = (int)numericUpDown1.Value;
            ((ZapisZur)this.Tag).addedPeriodToEnd = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            dateTimePicker1.Value = beginTime.AddMinutes(-(int)numericUpDown1.Value);
        }

        private void numericUpDown2_Validated(object sender, EventArgs e)
        {
            dateTimePicker2.Value = endTime.AddMinutes((int)numericUpDown2.Value);
        }

    }
}
