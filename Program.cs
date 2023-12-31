namespace SRRH
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
           
            /*
            Organizar las tabindex para que se viaje comodamente entre los elementros
            
            
             */
            
            Login primero = new Login();
            Application.Run(primero); //indico que el primero en ser ejecutado es el login
            if (primero.acceso) //una vez se cierre el login, verifica el acceso
            {
                Application.Run(new Inicio(primero.ingreso)); //al ser afirmatico ejecuta el inicio

            }
            
            

        }
    }
}