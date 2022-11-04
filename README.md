## INSTRUÇÕES PARA O TESTE TÉCNICO

- Crie um fork deste projeto (https://gitlab.com/Pottencial/tech-test-payment-api/-/forks/new). É preciso estar logado na sua conta Gitlab;
- Adicione @Pottencial (Pottencial Seguradora) como membro do seu fork. Você pode fazer isto em  https://gitlab.com/`your-user`/tech-test-payment-api/settings/members;
 - Quando você começar, faça um commit vazio com a mensagem "Iniciando o teste de tecnologia" e quando terminar, faça o commit com uma mensagem "Finalizado o teste de tecnologia";
 - Commit após cada ciclo de refatoração pelo menos;
 - Não use branches;
 - Você deve prover evidências suficientes de que sua solução está completa indicando, no mínimo, que ela funciona;

## O TESTE
- Construir uma API REST utilizando .Net Core, Java ou NodeJs (com Typescript);
- A API deve expor uma rota com documentação swagger (http://.../api-docs).
- A API deve possuir 3 operações:
  1) Registrar venda: Recebe os dados do vendedor + itens vendidos. Registra venda com status "Aguardando pagamento";
  2) Buscar venda: Busca pelo Id da venda;
  3) Atualizar venda: Permite que seja atualizado o status da venda.
     * OBS.: Possíveis status: `Pagamento aprovado` | `Enviado para transportadora` | `Entregue` | `Cancelada`.
- Uma venda contém informação sobre o vendedor que a efetivou, data, identificador do pedido e os itens que foram vendidos;
- O vendedor deve possuir id, cpf, nome, e-mail e telefone;
- A inclusão de uma venda deve possuir pelo menos 1 item;
- A atualização de status deve permitir somente as seguintes transições: 
  - De: `Aguardando pagamento` Para: `Pagamento Aprovado`
  - De: `Aguardando pagamento` Para: `Cancelada`
  - De: `Pagamento Aprovado` Para: `Enviado para Transportadora`
  - De: `Pagamento Aprovado` Para: `Cancelada`
  - De: `Enviado para Transportador`. Para: `Entregue`
- A API não precisa ter mecanismos de autenticação/autorização;
- A aplicação não precisa implementar os mecanismos de persistência em um banco de dados, eles podem ser persistidos "em memória".

## PONTOS QUE SERÃO AVALIADOS
- Arquitetura da aplicação - embora não existam muitos requisitos de negócio, iremos avaliar como o projeto foi estruturada, bem como camadas e suas responsabilidades;
- Programação orientada a objetos;
- Boas práticas e princípios como SOLID, DDD (opcional), DRY, KISS;
- Testes unitários;
- Uso correto do padrão REST;



Minha implementação(conclusão):

Este desafio de projeto foi baseado na contstrução de uma API de pagamento onde usei os conhecimentos adquiridos durante o processo de aprendizagem no bootcamp.
Criando uma Api fincional usando os métodos:
HttPut:
O Serviço de Integração de Dados usa o método Put HTTP para atualizar dados através de um serviço da Web REST.
Método HttpGet: é usado para solicitar dados de recursos especificados. Ele envia um corpo vazio para o servidor e pede para obter recursos. Se os dados do formulário forem enviados usando o método GET, os dados enviados pelo servidor serão anexados ao URL da página. Suas requests têm algumas restrições de comprimento. Não é usado para modificação. 
Método HttpPost:é usado para enviar dados a um servidor para criar e atualizar um recurso. Os dados solicitados usando o método POST são anexados ao corpo da solicitação HTTP em vez do URL da página. Sua solicitação não tem restrições quanto ao comprimento dos dados. 
E através do uso do EntityFramework e MicrosoftEntityFramework.SqlServer e com o uso do MSqlSerer Studio gerando um banco de dados para a criação de tabelas no nosso banco de dados assim juntamente com os conhecimentos adquiridos consegui criar essa APi onde se passa todas as etapas de uma compra online.

