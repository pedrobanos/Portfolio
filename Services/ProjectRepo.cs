using Portfolio.Models;

namespace Portfolio.Services
{

    public interface IProjectRepo
    {
        List<Project> ObtainProjects();
    }
    public class ProjectRepo: IProjectRepo
    {
        public List<Project> ObtainProjects()
        {
            return new List<Project>(){
            new Project
            {
                Tittle= "Garage Manager",
                Description= "App made with Backend-tech: EXPRESS, NodeJS, JS, MongoDB Technologies, Frontend-tech: React ",
                Link= "https://garage-manager.netlify.app/",
                ImageURL= "/Images/proyecto32.png"

            },
            new Project
            {
                Tittle= "IronClubbers",
                Description= "App made with EXPRESS, NodeJS, JS, MongoDB Technologies",
                Link= "http://ironclubbers.herokuapp.com/ ",
                ImageURL= "/Images/proyecto2.png"

            },
            new Project
            {
                Tittle= "Zombie Apocalypse",
                Description= "A 2D video game project to get familiar with JS language using\r\nCanvas tech.",
                Link= "https://github.com/pedrobanos/zombie-apocalypse",
                ImageURL= "/Images/proyecto1.png"

            },
            new Project
            {
                Tittle= "Renault España",
                Description= "Retailer Chef",
                Link= "https://www.renault.com ",
                ImageURL= "/Images/renault1.jpg"

            }
            };
        }

    }
}
