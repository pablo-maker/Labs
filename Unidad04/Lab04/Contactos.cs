﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab04
{
    public class Contactos
    {
        protected DataTable misContactos;

        public Contactos()
        {
            this.misContactos = this.getTabla();
        }
        public virtual DataTable getTabla()
        {
            return new DataTable();
        }
        public virtual void aplicarCambios()
        {

        }
        public void listar()
        {
            foreach (DataRow fila in this.misContactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn col in this.misContactos.Columns)
                    {
                        Console.WriteLine("{0}: {1}", col.ColumnName, fila[col]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void nuevaFila()
        {
            DataRow fila = this.misContactos.NewRow();
            foreach (DataColumn col in this.misContactos.Columns)
            {
                Console.WriteLine("ingrese {0}", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
            this.misContactos.Rows.Add(fila);
        }
        public void editarFila()
        {
            Console.WriteLine("Ingrese el numero de fila a editar:");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = this.misContactos.Rows[nroFila - 1];
            for (int nroCol = 1; nroCol < this.misContactos.Columns.Count; nroCol++)//0 se omite por ser la id
            {
                DataColumn col = this.misContactos.Columns[nroCol];
                Console.WriteLine("Ingrese {0}", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
        }
        public void eliminarFila()
        {
            Console.WriteLine("Ingrese el nro de fila a eliminar:");
            int fila = int.Parse(Console.ReadLine());
            this.misContactos.Rows[fila - 1].Delete();
        }
    }
}
