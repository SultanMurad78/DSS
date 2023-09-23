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
    public partial class dayParam : Form
    {
        public dayParam()
        {
            InitializeComponent();
        }

        bool b = true;

        private void dayParam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b)
            {

                this.Validate();
                int raz = (int)(Math.Truncate((double)((dateTimePickerEnd.Value.TimeOfDay.TotalMinutes - dateTimePickerBeg.Value.TimeOfDay.TotalMinutes))) - Math.Truncate((double)(dateTimePickerEnd.Value.TimeOfDay.TotalMinutes - dateTimePickerBeg.Value.TimeOfDay.TotalMinutes) / Convert.ToInt32(numericUpDownPeriod.Value)) * Convert.ToInt32(numericUpDownPeriod.Value));
                if (dateTimePickerBeg.Value >= dateTimePickerEnd.Value)
                {
                    MessageBox.Show("Смена должна начаться,прежде чем закончится.");
                    e.Cancel = true;
                }

                else if ((dateTimePickerEnd.Value.TimeOfDay - dateTimePickerBeg.Value.TimeOfDay).TotalMinutes / Convert.ToInt32(numericUpDownPeriod.Value) -
                Math.Truncate((double)(dateTimePickerEnd.Value.TimeOfDay.TotalMinutes - dateTimePickerBeg.Value.TimeOfDay.TotalMinutes) / Convert.ToInt32(numericUpDownPeriod.Value)) != 0)
                {
                    DialogResult r = MessageBox.Show("Выбранная продолжительность приема не умещается в рабочем дне целое количество раз. Смена будет уменьшена на " + raz.ToString() + " минут.\rПродолжить?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (r == DialogResult.No)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else if (r == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        if (this.Tag.GetType() == typeof(RaspChenge))
                        {
                            ifTagRaspCh();
                        }
                        else if (this.Tag.GetType() == typeof(ZapisZur))
                        {
                            ifTagZapisZur();
                        }
                    }
                }
                else
                {
                    if (this.Tag.GetType() == typeof(RaspChenge))
                    {
                        ifTagRaspCh();
                    }
                    else if (this.Tag.GetType() == typeof(ZapisZur))
                    {
                        ifTagZapisZur();
                    }
                }
            }
        }

        private void ifTagRaspCh()
        {
            ((RaspChenge)this.Tag).begDay = dateTimePickerBeg.Value;
            ((RaspChenge)this.Tag).endDay = dateTimePickerEnd.Value;
            ((RaspChenge)this.Tag).perDay = Convert.ToInt32(numericUpDownPeriod.Value);

        }


        private void ifTagZapisZur()
        {
            ((ZapisZur)this.Tag).begDay = dateTimePickerBeg.Value;
            ((ZapisZur)this.Tag).endDay = dateTimePickerEnd.Value;
            ((ZapisZur)this.Tag).perDay = Convert.ToInt32(numericUpDownPeriod.Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = true;
        }

        private void dayParam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                b = false;
                this.Close();
            }
        }
    }
}
