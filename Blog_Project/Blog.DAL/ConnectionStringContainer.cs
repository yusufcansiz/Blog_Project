namespace Blog.DAL
{
    class ConnectionStringContainer
    {
        internal static string ConnectionString
        {
            //get { return "Server=DESKTOP-9O81J9B\\SQLEXPRESS; Database=ETicaretDB; Integrated Security = True; MultipleActiveResultSets =true;"; }

            get { return "Server=.; Database=ETicaretDB; Uid=sa; Pwd=123"; }
        }
    }
}