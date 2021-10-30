using Examen_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_1.Utilidades
{
    public class CargaPaquetes
    {
        public static List<Paquete> CargaInformacionSobrePaquetes()
        {
            List<Paquete> ListaPaquetes = new List<Paquete>();
            Paquete Paquete;
            CaracteristicasPaquete caracteristicas;
            ExtraPaquete ExtraPaquete;
            List<CaracteristicasPaquete> ListaCaracteristicasPaquete;
            List<ExtraPaquete> ListaPaqueteExtra;
            try
            {
                #region Piscina de agua dulce paquete semanal
                ListaCaracteristicasPaquete = new List<CaracteristicasPaquete>();
                ListaPaqueteExtra = new List<ExtraPaquete>();

                Paquete = new Paquete { Id = 1, Nombre = "Piscina de agua dulce paquete semanal", PrecioVisita = 30000, Codigo = "Pool01" };

                #region Caracteristicas 
                caracteristicas = new CaracteristicasPaquete { Id = 1, Descripcion = "Análisis químico de agua de piscina una vez por semana" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                caracteristicas = new CaracteristicasPaquete { Id = 2, Descripcion = "Balance químico PH y aplicación de productos una vez por semana" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                caracteristicas = new CaracteristicasPaquete { Id = 3, Descripcion = "Mantenimiento y operación de piscinas una vez por semana" };
                ListaCaracteristicasPaquete.Add(caracteristicas);
                #endregion

                #region Extras 
                ExtraPaquete = new ExtraPaquete { Id = 1, Precio = 10000, Descripcion = "Aplicación de alguicida" };
                ListaPaqueteExtra.Add(ExtraPaquete);

                ExtraPaquete = new ExtraPaquete { Id = 2, Precio = 10000, Descripcion = "Limpieza profunda de bomba" };
                ListaPaqueteExtra.Add(ExtraPaquete);

                ExtraPaquete = new ExtraPaquete { Id = 3, Precio = 5000, Descripcion = "Cambio de luces" };
                ListaPaqueteExtra.Add(ExtraPaquete);

                ExtraPaquete = new ExtraPaquete { Id = 4, Precio = 15000, Descripcion = "Limpieza de fondo profunda" };
                ListaPaqueteExtra.Add(ExtraPaquete);
                #endregion

                Paquete.ListaCaracteristicas = ListaCaracteristicasPaquete;
                ListaCaracteristicasPaquete = null;

                Paquete.ListaPaqueteExtras = ListaPaqueteExtra;
                ListaPaqueteExtra = null;

                ListaPaquetes.Add(Paquete);
                Paquete = null;

                #endregion

                #region Piscina de agua salada paquete mensual
                ListaCaracteristicasPaquete = new List<CaracteristicasPaquete>();
                ListaPaqueteExtra = new List<ExtraPaquete>();

                Paquete = new Paquete { Id = 2, Nombre = "Piscina de agua salada paquete mensual", PrecioVisita = 20000, Codigo = "Pool02" };

                #region Caracteristicas 
                caracteristicas = new CaracteristicasPaquete { Id = 1, Descripcion = "Análisis químico de agua de piscina una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                caracteristicas = new CaracteristicasPaquete { Id = 2, Descripcion = "Balance químico PH y aplicación de productos una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                caracteristicas = new CaracteristicasPaquete { Id = 3, Descripcion = "Mantenimiento y operación de piscinas una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);
                #endregion

                #region Extras 
                ExtraPaquete = new ExtraPaquete { Id = 1, Precio = 10000, Descripcion = "Aplicación de alguicida" };
                ListaPaqueteExtra.Add(ExtraPaquete);

                ExtraPaquete = new ExtraPaquete { Id = 2, Precio = 10000, Descripcion = "Limpieza profunda de bomba" };
                ListaPaqueteExtra.Add(ExtraPaquete);

                ExtraPaquete = new ExtraPaquete { Id = 3, Precio = 5000, Descripcion = "Cambio de luces" };
                ListaPaqueteExtra.Add(ExtraPaquete);

                ExtraPaquete = new ExtraPaquete { Id = 4, Precio = 15000, Descripcion = "Limpieza de fondo profunda" };
                ListaPaqueteExtra.Add(ExtraPaquete);
                #endregion

                Paquete.ListaCaracteristicas = ListaCaracteristicasPaquete;
                ListaCaracteristicasPaquete = null;

                Paquete.ListaPaqueteExtras = ListaPaqueteExtra;
                ListaPaqueteExtra = null;

                ListaPaquetes.Add(Paquete);
                Paquete = null;

                #endregion

                #region Piscina de agua dulce visita extra
                ListaCaracteristicasPaquete = new List<CaracteristicasPaquete>();
                ListaPaqueteExtra = new List<ExtraPaquete>();

                Paquete = new Paquete { Id = 3, Nombre = "Piscina de agua dulce visita extra", PrecioVisita = 10000, Codigo = "Pool03" };

                #region Caracteristicas 
                caracteristicas = new CaracteristicasPaquete { Id = 1, Descripcion = "Análisis químico de agua de piscina una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                caracteristicas = new CaracteristicasPaquete { Id = 2, Descripcion = "Balance químico PH y aplicación de productos una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                #endregion


                Paquete.ListaCaracteristicas = ListaCaracteristicasPaquete;
                ListaCaracteristicasPaquete = null;

                ListaPaquetes.Add(Paquete);
                Paquete = null;

                #endregion

                #region Piscina de agua dulce visita extra
                ListaCaracteristicasPaquete = new List<CaracteristicasPaquete>();
                ListaPaqueteExtra = new List<ExtraPaquete>();

                Paquete = new Paquete { Id = 4, Nombre = "Piscina de agua salada visita extra", PrecioVisita = 15000, Codigo = "Pool04" };

                #region Caracteristicas 
                caracteristicas = new CaracteristicasPaquete { Id = 1, Descripcion = "Análisis químico de agua de piscina una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                caracteristicas = new CaracteristicasPaquete { Id = 2, Descripcion = "Balance químico PH y aplicación de productos una vez por mes" };
                ListaCaracteristicasPaquete.Add(caracteristicas);

                #endregion


                Paquete.ListaCaracteristicas = ListaCaracteristicasPaquete;
                ListaCaracteristicasPaquete = null;

                ListaPaquetes.Add(Paquete);
                Paquete = null;

                #endregion

                return ListaPaquetes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
