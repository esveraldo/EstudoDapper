﻿namespace EstudoDapper.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        
        IClienteRepository ClienteRepository { get; }
        IConjugeRepository ConjugeRepository { get; }
        IImovelRepository IImovelRepository { get; }
        IPessoaFisicaRepository PessoaFisicaRepository { get; }
        IPessoaJuridicaRepository PessoaJuridicaRepository { get; }

    }
}
