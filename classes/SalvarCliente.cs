using System;
using System.IO;

namespace CadastroVendaPOO
{
    public class SalvarCliente
    {
        public string Salvar(Cliente cliente)
        {
            string msg = "";
            StreamWriter sw = null;

            try
            {
                if (cpfvalido(cliente.Cpf))
                {
                    sw = new StreamWriter("arquivos/_Clientes.csv", true);
                    sw.WriteLine(cliente.Nome + ";" + cliente.Email + ";" + cliente.Cpf + ";" + cliente.DataCadastro);
                    msg = "Cliente salvo com sucesso";
                }
                else
                {
                    msg = "CPF inválido";
                }
                
            }
            catch (Exception ex)
            {
                msg = "Erro na manipulação do arquivo: " + ex.Message;
            }
            finally
            {
                sw.Close();
            }
            return msg;
        }

        private bool cpfvalido(string cpf)
        {
            bool rs = true;
            string cpfCalculado = cpf.Substring(0, 9);
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < cpfCalculado.Length; i++)
            {
                soma += (Int32.Parse(cpfCalculado.Substring(i, 1)) * multiplicador1[i]);
            }
            if (soma % 11 < 2)
            {
                cpfCalculado += 0;
            }
            else
            {
                cpfCalculado += (11 - (soma % 11));
            }

            soma = 0;
            for (int i = 0; i < cpfCalculado.Length; i++)
            {
                soma += (Int32.Parse(cpfCalculado.Substring(i, 1)) * multiplicador2[i]);
            }

            if (soma % 11 < 2)
            {
                cpfCalculado += 0;
            }
            else
            {
                cpfCalculado += (11 - (soma % 11));
            }
            if (cpfCalculado != cpf)
            {
                rs = false;
                return rs;
            }
            return rs;
        }
    }
}