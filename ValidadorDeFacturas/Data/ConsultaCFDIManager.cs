using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Sat.Cfdi.Negocio.ConsultaCfdi.Servicio;

namespace ValidadorDeFacturas.Data
{
    public class ConsultaCFDIManager
    {
        private const string Url = "https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc";

        private ConsultaCFDIServiceClient GetClient()
        {
            return new ConsultaCFDIServiceClient(new BasicHttpBinding(), new EndpointAddress(Url));
        }

        public async Task<Acuse> ConsultaAsync(string expresionImpresa)
        {
            TaskCompletionSource<Acuse> tcs = new TaskCompletionSource<Acuse>();

            using (ConsultaCFDIServiceClient client = GetClient())
            {
                using (var context = new OperationContextScope(client.InnerChannel))
                {
                    tcs.TrySetResult(await client.ConsultaAsync(expresionImpresa));
                }
            }

            return await tcs.Task;
        }
    }
}
