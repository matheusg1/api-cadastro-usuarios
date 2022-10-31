﻿using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace UsuariosApi.Models
{
    public class Mensagem
    {

        public List<MailboxAddress> Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        public Mensagem(IEnumerable<string> destinatario, string assunto, int usuarioId, string codigo)
        {
            Destinatario = new List<MailboxAddress>();
            Destinatario.AddRange(destinatario.Select(e => new MailboxAddress(e)));

            Assunto = assunto;
            Conteudo = $"http://localhost:6000/ativa/usuarioId={usuarioId}&CodigoDeAtivacao={codigo}";
        }
    }
}
