using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprar_Vuelos
{
    internal class ClsVuelos
    {
        public static void MostrarReserva(string PuntoPartida, string Destino, DateTime FechaViaje, int AsientosDisponibles)
        {
            MessageBox.Show($"Se ha reservado su vuelo\n" +
                            $"El punto de partida es: {PuntoPartida}\n" +
                            $"El destino es: {Destino}\n" +
                            $"La fecha es: {FechaViaje}\n" +
                            $"Asientos disponibles: {AsientosDisponibles}");
        }
    }
}
