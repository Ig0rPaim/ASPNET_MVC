using BuilderAux_MVC.Data;
using BuilderAux_MVC.Models;

namespace BuilderAux_MVC.Repository.UserRepository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AplicationDbContextUsuario _DbUser;
        public UsersRepository(AplicationDbContextUsuario DbUser) // injeçao de dependencia por construtor, estou injetando a classe q herda o dbContext
        {
            _DbUser = DbUser;
        }
        public UsuarioModel Add(UsuarioModel User)
        {
            User.DataCadastro = DateTime.Now;
            _DbUser.Usuarios.Add(User);
            _DbUser.SaveChanges();
            return User;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel UserDb = ListById(usuario.Id);

            if (UserDb == null) throw new Exception("Erro na atualização do usuario");

            UserDb.Nome = usuario.Nome;
            UserDb.Email = usuario.Email;
            UserDb.Phone = usuario.Phone;
            UserDb.Password = usuario.Password;
            UserDb.DataAtualizacao = DateTime.Now;

            _DbUser.Usuarios.Update(UserDb);
            _DbUser.SaveChanges();

            return UserDb; 
        }

        public bool DeleteUser(int id)
        {
            UsuarioModel UserDb = ListById(id);

            if (UserDb == null) throw new Exception("Erro na deleção do usuario");

            _DbUser.Usuarios.Remove(UserDb);
            _DbUser.SaveChanges();

            return true;
        }

        public List<UsuarioModel> GetAll()
        {
            return _DbUser.Usuarios.ToList();
        }

        public UsuarioModel ListById(int id)
        {
            return _DbUser.Usuarios.FirstOrDefault(x => x.Id == id);
        }
    }
}
