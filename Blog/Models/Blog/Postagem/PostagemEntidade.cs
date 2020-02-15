using Blog.Models.Blog.Autor;
using Blog.Models.Blog.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntidade
    {
        public String Titulo;
        public AutorEntidade autor;
        public CategoriaEntidade Categoria;

    }
}
