using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingSystem;
public class Estacionamento
{
    private string _tipoVeiculo;
    private string _marca;
    private string _modelo;
    private int _ano;
    private string _placa;

    public string TipoVeiculo { get => getTipoVeiculo(); set => setTipoVeiculo(value); }
    public string Marca { get => getMarca(); set => setMarca(value); }
    public string Modelo { get => getModelo(); set => setModelo(value); }
    public int Ano { get => getAno(); set => setAno(value); }
    public string Placa { get => getPlaca(); set => setPlaca(value); }

    public Estacionamento()
    {
    }

    public Estacionamento(string tipoVeiculo, string marca, string modelo, int ano, string placa)
    {
        this.TipoVeiculo = tipoVeiculo;
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
        this.Placa = placa;
    }

    private string getTipoVeiculo()
    {
        return this._marca;
    }
    private void setTipoVeiculo(string tipoVeiculo)
    {
        this._tipoVeiculo = tipoVeiculo;
    }
    private string getMarca()
    {
        return this._marca;
    }
    private void setMarca(string marca)
    {
        this._marca = marca;
    }
    private string getModelo()
    {
        return this._modelo;
    }
    private void setModelo(string modelo)
    {
        this._modelo = modelo;
    }
    private int getAno()
    {
        return this._ano;
    }
    private void setAno(int ano)
    {
        this._ano = ano;
    }
    private string getPlaca()
    {
        return this._placa;
    }
    private void setPlaca(string placa)
    {
        this._placa = placa;
    }

}
