using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Database.Repositories.Interfaces;
using projeto_02.Models;
using projeto_02.Models.Enum;
using projeto_02.Models.ViewModels;
using projeto_02.Services.Interfaces;

namespace projeto_02.Services
{
  public class ColecoesService : IColecoesService
  {
    private readonly IColecoesRepository _colecoesRepository;

    public ColecoesService(IColecoesRepository colecoesRepository)
    {
      _colecoesRepository = colecoesRepository;
    }

    public async Task<bool?> CreateAsync(PostColecao postColecao)
    {
      try
      {
        if (await _colecoesRepository.CheckNomeColecaoAsync(postColecao.NomeColecao))
          return null;

        var colecao = new Colecao
        {
          NomeColecao = postColecao.NomeColecao,
          IdResponsavel = postColecao.IdResponsavel,
          Marca = postColecao.Marca,
          Orcamento = postColecao.Orcamento,
          AnoLancamento = postColecao.AnoLancamento,
          Estacao = postColecao.Estacao,
          EstadoSistema = postColecao.EstadoSistema,
        };

        return await _colecoesRepository.CreateAsync(colecao);
      }
      catch (Exception e)
      {
        return false;
      }
    }

    public async Task<bool?> UpdateAsync(PutColecao putColecao)
    {
      try
      {
        var colecao = await _colecoesRepository.GetByIdAsync(putColecao.Id);

        if (colecao == null)
          return null;

        if (!string.IsNullOrEmpty(putColecao.NomeColecao))
          colecao.NomeColecao = putColecao.NomeColecao;

        if (putColecao.IdResponsavel != 0)
          colecao.IdResponsavel = putColecao.IdResponsavel;

        if (!string.IsNullOrEmpty(putColecao.Marca))
          colecao.Marca = putColecao.Marca;

        if (putColecao.Orcamento != 0)
          colecao.Orcamento = putColecao.Orcamento;

        if (putColecao.AnoLancamento != DateTime.MinValue)
          colecao.AnoLancamento = putColecao.AnoLancamento;

        if (Enum.IsDefined(typeof(Estacao), putColecao.Estacao))
          colecao.Estacao = putColecao.Estacao;

        return await _colecoesRepository.UpdateAsync(colecao);
      }
      catch (Exception e)
      {
        return false;
      }
    }

    public async Task<bool?> UpdateEstadoSistemaAsync(int id, EstadoSistema estadoSistema)
    {
      try
      {
        var colecao = await _colecoesRepository.GetByIdAsync(id);

        if (colecao == null)
          return null;

        if (!Enum.IsDefined(typeof(EstadoSistema), estadoSistema))
          return null;

        return await _colecoesRepository.UpdateEstadoSistemaAsync(id, estadoSistema);

      }
      catch (Exception e)
      {
        return false;
      }
    }

    public async Task<List<Colecao>> GetAllAsync(EstadoSistema? estadoSistema)
    {
      return await _colecoesRepository.GetAllAsync(estadoSistema);
    }

    public async Task<Colecao?> GetByIdAsync(int id)
    {
      return await _colecoesRepository.GetByIdAsync(id);
    }

    public Task<bool?> UpdateStatusAsync(int id, EstadoSistema estadoSistema)
    {
      throw new NotImplementedException();
    }
  }
}
