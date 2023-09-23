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
    public partial class DelimVremya : Form
    {
        public DelimVremya()
        {
            InitializeComponent();
        }
        public DateTime startTime = new DateTime();
        DateTime secondTime = new DateTime();
        public int periodDefault = 0;


        private void DelimVremya1_Load(object sender, EventArgs e)
        {

            textBoxT1S.Text = startTime.ToShortTimeString();
            dateTimePickerT2S.MinDate = dateTimePickerT2S.Value = secondTime = startTime;
            numericUpDownT2Per.Value = numericUpDownT2Per.Maximum = numericUpDownT1Per.Maximum = trackBarMy.Maximum = periodDefault;
            dateTimePickerT2S.MaxDate = startTime.AddMinutes(periodDefault);
        }

        private void trackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            secondTime = startTime.AddMinutes(trackBarMy.Value);
            dateTimePickerT2S.Value = secondTime;
            numericUpDownT2Per.Value = periodDefault - trackBarMy.Value;
            numericUpDownT1Per.Value = trackBarMy.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trackBarMy.Value != 0 && trackBarMy.Value != periodDefault)
            {
                if (this.Tag.GetType() == typeof(ZapisZur))
                {
                    ((ZapisZur)this.Tag).data_new_delim = secondTime;
                    ((ZapisZur)this.Tag).new_per_delim = trackBarMy.Value;
                    if (radioButton2.Checked)
                    {
                        ((ZapisZur)this.Tag).where_zap_whill_delim = false;
                    }
                    else
                    {
                        ((ZapisZur)this.Tag).where_zap_whill_delim = true;
                    }
                }
                else if (this.Tag.GetType() == typeof(RaspChenge))
                {
                    ((RaspChenge)this.Tag).data_new_delimRasCh = secondTime;
                    ((RaspChenge)this.Tag).new_per1 = trackBarMy.Value;
                    if (radioButton2.Checked)
                    {
                        ((RaspChenge)this.Tag).where_zapDelim = false;
                    }
                    else
                    {
                        ((RaspChenge)this.Tag).where_zapDelim = true;
                    }
                }
            }
            else
            {

                this.DialogResult = DialogResult.No;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownT1Per.Focused)
            {
                trackBarMy.Value = (int)numericUpDownT1Per.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownT2Per.Focused)
            {
                trackBarMy.Value = periodDefault - (int)numericUpDownT2Per.Value;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerT2S.Focused)
            {
                trackBarMy.Value = (int)(dateTimePickerT2S.Value.TimeOfDay - startTime.TimeOfDay).TotalMinutes;
            }
        }
    }
}
