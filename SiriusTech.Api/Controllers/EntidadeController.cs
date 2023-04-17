using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SiriusTech.Data.Models;
using SiriusTech.Domain.DTOs.Response;
using SiriusTech.Domain.Interfaces.Repositories;

namespace SiriusTech.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntidadeController : Controller
    {

        private readonly IEntidadeRepository _entidadeRepository;
        private readonly IMapper _mapper;

        public EntidadeController(IEntidadeRepository entidadeRepository, IMapper mapper)
        {
            _entidadeRepository = entidadeRepository;
            _mapper = mapper;
        }

        [HttpGet("SelecionarTodos")]
        public async Task<ActionResult<IEnumerable<Entidade>>> GetEntidades()
        {
            var entidades = await _entidadeRepository.SelecionarTodos();
            var entidadesResponse = _mapper.Map<IEnumerable<EntidadeResponse>>(entidades);
            return Ok(entidadesResponse);
        }

        [HttpPost("CadastrarEntidade")]
        public async Task<ActionResult> CadastrarEntidade(EntidadeRequest entidadeRequest)
        {
            var entidade = _mapper.Map<Entidade>(entidadeRequest);
            _entidadeRepository.Incluir(entidade);
            if (await _entidadeRepository.SaveAllAsync())
            {
                return Ok("Entidade cadastrada com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao salvar a Entidade");
        }

        [HttpPut("AlterarEntidade/{idEntidade}")]
        public async Task<ActionResult> AlterarEntidade(EntidadeRequest entidadeRequest)
        {
            if (entidadeRequest == 0)
            {
                return BadRequest("Não é possivel alterar a Entidade. É preciso informar o ID");
            }


            var entidadeExiste = await _entidadeRepository.SelecionarByPk(entidadeRequest.IdEntidade);
            if (entidadeExiste == null)
            {
                return NotFound("Entidade não encontrada");
            }

            var entidade = _mapper.Map<Entidade>(entidadeRequest);
            _entidadeRepository.Alterar(entidade);
            if (await _entidadeRepository.SaveAllAsync())
            {
                return Ok("Entidade alterada com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao alterar a Entidade");
        }


        [HttpDelete("ExcluirEntidade/{idEntidade}")]
        public async Task<ActionResult> ExcluirEntidade(int idEntidade)
        {
            var entidade = await _entidadeRepository.SelecionarByPk(idEntidade);

            if (entidade == null)
            {
                return NotFound("Entidade não encontrada");
            }


            _entidadeRepository.Excluir(entidade);

            if (await _entidadeRepository.SaveAllAsync())
            {
                return Ok("Entidade excluida com sucesso!");
            }

            return BadRequest("Ocorreu um erro ao excluir a Entidade");
        }

        [HttpGet("SelecionarIdEntidade/{idEntidade}")]
        public async Task<ActionResult> SlecionarCliente(int idEntidade)
        {
            var entidade = await _entidadeRepository.SelecionarByPk(idEntidade);

            if (entidade == null)
            {
                return NotFound("Entidade não encontrada");
            }

            //Mapeamento Manual
            EntidadeResponse entidadeResponse = new EntidadeResponse
            {
                IdEntidade = entidade.IdEntidade,
                DataRegistro = entidade.DataRegistro,
                CpfCnpj = entidade.CpfCnpj,
                DcrEntidade = entidade.DcrEntidade,
                DcrCep = entidade.DcrCep,
                DcrEndereco = entidade.DcrEndereco,
                DcrNumero = entidade.DcrNumero,
                IdCidade = entidade.IdCidade,
                IdBairro = entidade.IdBairro,
                IdEstado = entidade.IdEstado,
                IdPais = entidade.IdPais
            };

            //Mapeamento Automatico - AutoMapper
            var entidadesResponse = _mapper.Map<EntidadeResponse>(entidade);

            return Ok(entidadesResponse);
        }

    }
}
