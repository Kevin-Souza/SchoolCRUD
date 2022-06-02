using TemplateBootstrap.Models;
using static TemplateBootstrap.Data.AppContext;

namespace TemplateBootstrap.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar tarefas
                if (!context.Funcionarios.Any())
                {
                    context.Funcionarios.AddRange(new List<funcionario>(){
                        new funcionario()
                            {
                                Nome = "Daniel",
                                Endereco = "Rua Chile, 75",
                                Email = "daniel@gmail.com"
                            },
                            new funcionario(){
                                    Nome = "Maria",
                                    Endereco = "Rua Argentina, 50",
                                    Email = "maria@hotmail.com.br"
                            },
                        new funcionario(){
                            Nome = "Lucas",
                            Endereco = "Rua Paraguai, 12",
                            Email = "lucas@outlook.com"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}