using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Facturas
{
    private int id_fac = 0;
    private Clientes cliente = null;
    private DateOnly fecha;
    private MetodosPagos m_pago = null;
    private double iva = 0.0;
    private double total = 0.0;
    private Detalles details = null;
    private Remitentes remi = null;
    private Mensajeros menj = null;

    public Facturas()
    {

    }

    public int Id_fac { get => this.id_fac; set => this.id_fac = value; }
    public double Iva { get => this.iva; set => this.iva = value; }
    public double Total { get => this.total; set => this.total = value; }
    public Clientes? Cliente { get => this.cliente; set => this.cliente = value; }
    public DateOnly Fecha { get => this.fecha; set => this.fecha = value; }
    public MetodosPagos? M_pago { get => this.m_pago; set => this.m_pago = value; }
    public Detalles? Details { get => this.details; set => this.details = value;  }
    public Remitentes? Remi { get => this.remi; set => this.remi = value; }
    public Mensajeros Menj { get => this.menj; set => this.menj = value; }

    public void administrarDetalles()
    {

    }

    public void validarEstado()
    {

    }

    public void validarFactura()
    {

    }

}