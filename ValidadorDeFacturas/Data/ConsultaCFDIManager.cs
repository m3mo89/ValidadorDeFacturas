using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Sat.Cfdi.Negocio.ConsultaCfdi.Servicio;

namespace ValidadorDeFacturas.Data
{
    public class ConsultaCFDIManager
    {
        private TaskCompletionSource<Acuse> _tcs;
        private const string Url = "https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc";

        private ConsultaCFDIServiceClient GetClient()
        {
            return new ConsultaCFDIServiceClient(new BasicHttpBinding(), new EndpointAddress(Url));
        }

        public async Task<Acuse> ConsultaAsync(string expresionImpresa)
        {
            _tcs = new TaskCompletionSource<Acuse>();

            ConsultaCFDIServiceClient client = GetClient();
            
            using (var context = new OperationContextScope(client.InnerChannel))
            {
                client.ConsultaCompleted += OnConsultaCompleted;
                client.ConsultaAsync(expresionImpresa);
            }

            return await _tcs.Task;
        }

        private void OnConsultaCompleted(object s, ConsultaCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _tcs.SetCanceled();
            }
            else if (e.Error != null)
            {
                _tcs.SetException(e.Error);
            }
            else
            {
                _tcs.SetResult(e.Result);
            }
        }
    }
}
