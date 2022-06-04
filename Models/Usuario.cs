using System.Collections.Generic;
using System.Linq;
using System;

namespace UsandoViews.Models{

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        private static List<Usuario> listagem = new List<Usuario>();

        public static IQueryable<Usuario> Listagem
        {
            get
            {
                return listagem.AsQueryable();
            }
        }

        static Usuario()
        {
            listagem.Add(new Usuario { IdUsuario = 1, Nome = "João", Email = "joao@gmail.com" });

            listagem.Add(new Usuario { IdUsuario = 2, Nome = "Andressa", Email = "andressa@gmail.com" });

            listagem.Add(new Usuario { IdUsuario = 3, Nome = "Rosimar", Email = "rosimar@gmail.com" });

            listagem.Add(new Usuario { IdUsuario = 4, Nome = "Josias", Email = "josias@gmail.com" });
        }

        public static void Salvar(Usuario usuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.IdUsuario == usuario.IdUsuario);
            
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
            }
            else
            {
                int MaiorId = 0;

                if (Usuario.listagem.Any())
                {
                    MaiorId = Usuario.listagem.Max(u => u.IdUsuario);
                }

                usuario.IdUsuario = MaiorId + 1;
                Usuario.listagem.Add(usuario);
            }
        }

        public static void Excluir(int idUsuario)
        {
            var UsuarioExistente = Usuario.listagem.Find(u => u.IdUsuario == idUsuario);
            
            if (UsuarioExistente != null)
            {
               Usuario.listagem.Remove(UsuarioExistente);
            }   
        }
    }
}