using System;
using ActivosTecnologicos;

namesacpe ActivosTecnologicos
{
    class Tablet : Activo
{
    private double tamanioPantalla;

    public Tablet(string marca, string modelo, int vidaUtilPredeterminada, int anioAdquisicion, bool estadoFuncionamiento, double tamanioPantalla) : base(marca, modelo, vidaUtilPredeterminada, anioAdquisicion, estadoFuncionamiento)
    {
        this.tamanioPantalla = tamanioPantalla;
    }

    public double TamanioPantalla
    {
        get { return tamanioPantalla; }
        set { this.tamanioPantalla = value; }
    }

    public override void calcularVidaUtilRestante()
    {
        double vidaUtil = base.VidaUtilPredeterminada - (2023 - (base.AnioAdquisicion));
        System.Console.WriteLine($"La vida util predeterminada es: {vidaUtil}");
    }

    public override void mostrarInformacion()
    {
        System.Console.WriteLine("Informacion de la Tablet: ");
        System.Console.Write($"Marca: {base.Marca}, Modelo: {base.Modelo}, ");
        System.Console.Write("Vida Util Predeterminada: " + calcularVidaUtilRestante + ", ");
        System.Console.Write($"Anio Adquisicion: {base.AnioAdquisicion}, ¿Esta Funcionando?: {base.EstadoFuncionamiento}, Espacio de Almacenamiento (GB): ");
    }
}
