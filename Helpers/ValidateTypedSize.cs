
namespace Large_File_Scanner.Helpers
{
    public static class ValidateTypedSize
    {
        public static bool KeyPress(object sender, KeyPressEventArgs e)
        {
            char dot = '.';


            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != dot) 
            {
                return true;
            }

            var tbx = (TextBox)sender;
            if(e.KeyChar == dot && tbx.Text.IndexOf(e.KeyChar) > -1)
            {
                return true;
            }

            return false;
        }
    }
}
