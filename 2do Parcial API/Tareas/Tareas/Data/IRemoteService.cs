using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace Tareas.Data
{
    public interface IRemoteService
    {
        /*TAREA*/
        [Get("/tarea")]
        Task<List<Tarea>> GetTarea();

        [Post("/tarea")]
        Task<Tarea> SetTarea(Tarea tra);

        [Get("/tarea/{id}")]
        Task<Tarea> GetIdTarea(int id);

        /*USUARIO*/
        [Get("/usuario")]
        Task<List<Usuario>> GetUsuario();

        [Get("/usuario/{id}")]
        Task<Usuario> GetIdUsuario(int id);

        [Post("/usuario")]
        Task<Usuario> SetUsuario(Usuario usr);

        /*DETALLE*/
        [Get("/detalle")]
        Task<List<Detalle>> GetDetalle();

        [Post("/detalle")]
        Task<Detalle> SetDetalle(Detalle deta);

        [Get("/detalle/{id}")]
        Task<Detalle> GetIdDetalle(int id);

        /*RECURSO*/
        [Get("/recurso")]
        Task<List<Recurso>> GetRecurso();

        [Post("/recurso")]
        Task<Recurso> SetRecurso(Recurso rec);

        [Get("/recurso/{id}")]
        Task<Recurso> GetIdRecurso(int id);
    }
}
