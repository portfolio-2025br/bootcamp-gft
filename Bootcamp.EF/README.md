# Projeto API e Entity Framework

## Notas

Destaco os seguintes pontos em minha proposta de solução:
- Todo o desenvolvimento foi feito usando-se o Linux;
- Usei o SQL Server via Docker no Linux (nada foi instalado no `host`);
- Migrei para .NET 8 e atualizei as dependências;
- Fiz uso de https; uso de tags; uso de rotas;
- Criei de endpoits novos (exemplo o /Info);
- Criei e testei manualmente o que foi solicitado;
- Adicionei rotinas de CI:
  - prettier para formatação e padronização de códigos;
  - commitlint para validação e padronização da mensagem de commit;
  - uso de analisadores estáticos de código (codeQL) para validar a qualidade do código;
  - atualizaçao automática de dependências com uso do Dependabot;
  - testei o projeto localmente (evidências de teste em
    <https://github.com/portfolio-2025br/bootcamp-gft/tree/main/Bootcamp.EF/Test>);
