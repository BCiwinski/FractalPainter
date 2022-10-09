using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalPainter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Autofac.ContainerBuilder builder = new Autofac.ContainerBuilder();
            builder.RegisterType<FractalDrawer.FractalDrawer>().As<FractalPainterInterfaces.IFractalDrawer>();
            builder.RegisterType<FractalDrawer.MandelbrotSet>().As<FractalPainterInterfaces.IFractal>();
            builder.RegisterType<FractalDrawer.BlackBluePalette>().As<FractalPainterInterfaces.IFractalColorPalette>();

            Autofac.IContainer container = builder.Build();
            Application.Run(new FractalPainterApp(container));
        }
    }
}
