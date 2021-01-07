using ExcelDataReader;
using ImportacaoXlsApi.Infraestutura.Notification;
using ImportacaoXlsApi.Models;
using ImportacaoXlsApi.Repository;
using System;
using System.Collections.Generic;
using System.IO;

namespace ImportacaoXlsApi.Service
{
    public class ImportacaoService : GenericService
    {
        private readonly ImportacaoRepository _repository;
        public ImportacaoService(INotification notification ,ImportacaoRepository repository) : base(notification)
        {
            this._repository = repository;
        }
        public IEnumerable<Importacao> GetAll()
        {
           return _repository.GetAll();
        }

        public Importacao Get(int id)
        {
            return _repository.Get(id);
        }
        public List<Importacao> UploadFile(Stream fileStream)
        {
            List<Importacao> importacoes = new List<Importacao>();
            IExcelDataReader reader;
            try
            {
                reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            }
            catch (Exception)
            {
                reader = ExcelReaderFactory.CreateBinaryReader(fileStream);
            }
            var count = 0;

            while (reader.Read())
            {
                if (count > 0)
                    if (reader[1] != null && !string.IsNullOrEmpty(reader[1].ToString()))
                        importacoes.Add(new Importacao
                        {
                            data_entrega = DateTime.Parse(reader[1].ToString()),
                            descricao = reader[2].ToString() ,
                            quantidade = int.Parse(reader[3].ToString()),
                            valor_unitario = decimal.Parse(reader[4].ToString())
                        });
                    else
                        break;
                count++;
            }

            foreach (var importacao in importacoes)
            {
                var import = new Importacao();
                import.data_entrega = importacao.data_entrega;
                import.descricao = importacao.descricao;
                import.quantidade = importacao.quantidade;
                import.valor_unitario = importacao.valor_unitario;
                _repository.Insert(import);
            }
            return importacoes;
        }
    }
}
