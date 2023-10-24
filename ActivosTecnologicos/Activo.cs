using System;

namespcae ActivosTecnologicos
{
    abstract class Activo
{
    private string marca;
    private string modelo;
    private int vidaUtilPredeterminada;
    private int anioAdquisicion;
    private bool estadoFuncionamiento;
    private List<MantenimientoActivo> mantenimientos;

    public Activo(string marca, string modelo, int vidaUtilPredeterminada, int anioAdquisicion, bool estadoFuncionamiento)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.vidaUtilPredeterminada = vidaUtilPredeterminada;
        this.anioAdquisicion = anioAdquisicion;
        this.estadoFuncionamiento = estadoFuncionamiento;
        this.mantenimientos = new List<MantenimientoActivo>();
    }

    public string Marca
    {
        get { return marca; }
        set { this.marca = value; }
    }

    public string Modelo { 
    {
        get { return modelo; }
        set { this.modelo = value; }
    }
    public int VidaUtilPredeterminada
    {
        get { return vidaUtilPredeterminada; }
        set { this.vidaUtilPredeterminada = value; }
    }

    public bool EstadoFuncionamiento
    {
        get { return estadoFuncionamiento; }
        set { this.estadoFuncionamiento = value; }
    }

    public List<MantenimientoActivo> Mantenimientos
    {
        get { return mantenimientos; }
    }

    public void agregarMantenimiento(MantenimientoActivo mantenimiento)
    {
        mantenimientos.Add(mantenimiento);
    }

    public abstract void calcularVidaUtilRestante();

    public abstract void mostrarInformacion();

}
