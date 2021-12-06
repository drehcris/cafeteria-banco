using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Cafeteria
{
    class MySql091121
    {
        public void chec()

        {
            /*MySqlConnection conexao;
        conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");*/

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }

                Console.WriteLine("Digite um nome para cadastrar/fazer login:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite uma senha para cadastrar/fazer login");
                string senha = Console.ReadLine();
                Console.WriteLine("Digite um email para cadastrar/fazer login");
                string email = Console.ReadLine();
                //string sql = "insert into usuarios values('" + usuario + "','" + senha + "','" + email + "')";
                string sql = "insert into cadastro_usuario (nome, senha, email) values (@nome, @senha, @email)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();


                Console.WriteLine("Digite um nome para bebida/comida");
                string objeto = Console.ReadLine();
                Console.WriteLine("Digite um valor para {0}", objeto);
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite uma quantidade para {0}", objeto);
                double quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("O novo preço é? {0}", valor * quantidade);
                Console.WriteLine("Obrigada(o)!");

               double novovalor = valor * quantidade;

            //string sql1 = "insert into bebidas/comidas values('" + valor + "','" + quantidade + "' + preco + "')";
            string sql1 = "insert into bebidas (nome, valor, quantidade, preco) values (@nome, @valor, @quantidade, @preco)";
            MySqlCommand abc = new MySqlCommand(sql1, conexao);
            abc.Parameters.AddWithValue("@nome", nome);
            abc.Parameters.AddWithValue("@valor", valor);
            abc.Parameters.AddWithValue("@quantidade", quantidade);
            abc.Parameters.AddWithValue("@preco", novovalor);
            abc.ExecuteNonQuery();

      

            select();
           
        }

        public void atualizar()
        {
            /*MySqlConnection conexao;
        conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");*/

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }

            Console.WriteLine("Digite um nome para cadastrar/fazer login:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite uma senha para cadastrar/fazer login");
            string senha = Console.ReadLine();
            Console.WriteLine("Digite um email para cadastrar/fazer login");
            string email = Console.ReadLine();
            //string sql = "insert into cadastro_usuario values('" + usuario + "','" + senha + "','" + email + "')";
            string sql = "update cadastro_usuario set nome=@nome, senha=@senha where email=@email";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();

                        
            select();

        }

        public void deletar()
        {
            /*MySqlConnection conexao;
        conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");*/

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }

            Console.WriteLine("Digite um email para cadastrar/fazer login");
            string email = Console.ReadLine();
            string sql = "delete from cadastro_usuario where email=@email";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();


            select();

        }

        public void select()
        {
            /* string sqldelete = "delete from cadastro_usuario";
                  cmd.ExecuteNonQuery(); */
            /*MySqlConnection conexao;
  conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");*/

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost; database=cafeteria; uid=root; password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");

            }

            
            string sqlselect = "select * from cadastro_usuario";
            MySqlCommand cmd = new MySqlCommand(sqlselect, conexao);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();
                      
            
           
            while (resultado.Read())
            {
                Console.WriteLine("cadastro_id:" + resultado["cadastro_id"]);
                Console.WriteLine("nome:" + resultado["nome"]);
                Console.WriteLine("senha:" + resultado["senha"]);
                Console.WriteLine("email:" + resultado["email"]);

            }
        }
    }
}
