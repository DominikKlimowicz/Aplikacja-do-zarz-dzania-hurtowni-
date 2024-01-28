using System;
using System.Windows.Forms;

public class NumericTextBox : TextBox
{
    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);

        // Zablokuj wprowadzanie znaków, które nie są cyframi ani znakami sterującymi
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}
