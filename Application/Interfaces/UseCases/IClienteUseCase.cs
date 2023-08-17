﻿namespace Application.Interfaces.UseCases
{
    public interface IClienteUseCase
    {
        public DTOs.Output.Cliente Get(int id);
        public IEnumerable<DTOs.Output.Cliente> List();
        public bool Delete(int id);
        public DTOs.Output.Cliente Insert(DTOs.Imput.Cliente cliente);
        public DTOs.Output.Cliente Update(DTOs.Imput.Cliente cliente);
        public DTOs.Output.Cliente GetByCpf(string cpf);
    }
}
