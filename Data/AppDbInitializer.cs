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
                        new funcionario(){
                            new funcionario()
                            {
                                Nome = "Daniel", Endereco = "Rua Chile, 75",
                                EnvironmentVariableTarget = "daniel@gmail.com"
                            }
                        }
                    });
                }

            }
        }
    }
}