public static class IndiceManager
{
    private static readonly HashSet<Pagina> IndicePaginas = new()
    {
        new Pagina { Titulo = "Como Calcular o Consumo de Água da Sua Residência", Link = "/blog/calcular-consumo-agua", Conteudo = "Calcular o consumo de água em sua residência é uma maneira importante de entender seus hábitos de uso e identificar áreas onde você pode economizar." },
        new Pagina { Titulo = "Como Calcular o Consumo de Gás Doméstico", Link = "/blog/calcular-consumo-gas", Conteudo = "Um passo a passo para medir o uso de gás em sua residência e entender como controlar melhor esse recurso." },
        new Pagina { Titulo = "Dicas Práticas para Reduzir a Conta de Luz", Link = "/blog/dicas-reduzir-conta-luz", Conteudo = "A conta de luz é uma das despesas mensais que mais pesam no orçamento doméstico. Felizmente, existem diversas estratégias que você pode adotar para diminuir o consumo de energia elétrica." },
        new Pagina { Titulo = "A Importância da Economia de Energia Elétrica", Link = "/blog/economia-energia", Conteudo = "Entenda por que é crucial reduzir o consumo de energia elétrica e como isso impacta não só o seu bolso, mas também o meio ambiente." },
        new Pagina { Titulo = "10 Dicas para Economizar Água em Casa", Link = "/blog/economize-agua", Conteudo = "A água é um recurso precioso e cada vez mais escasso. Economizar água não só ajuda a reduzir a sua conta mensal, mas também contribui para a preservação do meio ambiente." },
        new Pagina { Titulo = "Guia Completo para Economizar Gás em Casa", Link = "/blog/guia-economizar-gas", Conteudo = "Explore as melhores práticas para utilizar o gás de maneira mais eficiente, garantindo segurança e economia." },
        new Pagina { Titulo = "Impactos Ambientais do Desperdício de Recursos Naturais", Link = "/blog/impactos-desperdicios", Conteudo = "O desperdício de recursos naturais, como água, energia e gás, é um dos principais desafios ambientais da atualidade. O consumo excessivo contribui para mudanças climáticas e degradação de ecossistemas." },
        new Pagina { Titulo = "Como Criar uma Rotina Sustentável em Casa", Link = "/blog/rotina-sustentavel", Conteudo = "Adotar um estilo de vida sustentável não precisa ser complicado. Pequenas mudanças na rotina diária podem gerar um impacto positivo significativo para o meio ambiente." },
        new Pagina { Titulo = "A Importância da Sustentabilidade no Uso de Recursos", Link = "/blog/sustentabilidade", Conteudo = "A sustentabilidade é um dos temas mais relevantes da atualidade, pois está diretamente ligada à preservação dos recursos naturais e à qualidade de vida das futuras gerações. O consumo consciente de água, energia e gás pode trazer inúmeros benefícios para a sociedade, reduzindo impactos ambientais e promovendo economia para as famílias e empresas. Neste artigo, exploraremos a importância da sustentabilidade no uso desses recursos e como práticas sustentáveis podem transformar nossa realidade."},
        new Pagina { Titulo = "Tecnologias Modernas para Economizar Energia e Água", Link = "/blog/tecnologias-economizar-energia-agua", Conteudo = "A busca por soluções sustentáveis tem impulsionado o desenvolvimento de tecnologias inovadoras para reduzir o consumo de energia e água. Com o avanço da automação e dispositivos inteligentes, consumidores podem monitorar e otimizar seus gastos, reduzindo desperdícios e economizando dinheiro. Neste artigo, exploramos algumas das tecnologias mais eficientes para um consumo sustentável."},
        new Pagina { Titulo = "Sobre Nós - Calcula Fácil", Link = "/sobre-nos", Conteudo = "No Calcula Fácil, nossa missão é simplificar a vida das pessoas oferecendo ferramentas práticas e eficientes para realizar cálculos do dia a dia." },
        new Pagina { Titulo = "Calculadora de Consumo e Valor da Conta de Água", Link = "/consumo-agua", Conteudo = "Reduzir o consumo de água é fundamental para preservar nossos recursos naturais e diminuir suas contas mensais. importante para o planeta e para seu bolso! Use nossa calculadora para estimar seu gasto e identificar oportunidades de economia, consumo e custo aproximado com base na tarifa da Sabesp."},
        new Pagina { Titulo = "Calculadora de Consumo de Energia", Link = "/consumo-energia", Conteudo = "Economizar energia elétrica é essencial para reduzir custos e minimizar impactos ambientais. Use nossa calculadora para estimar seu gasto mensal de eletricidade."},
        new Pagina { Titulo = "Cálculo de Custo de Viagem", Link = "/custo-viagem", Conteudo = "Estime o gasto total da sua viagem, considerando combustível, pedágios e outros gastos."},
        new Pagina { Titulo = "FAQ - Calcula Fácil", Link = "/faq", Conteudo = "Perguntas e respostas sobre o site."},
        new Pagina { Titulo = "Política de Privacidade", Link = "/privacidade", Conteudo = "Bem-vindo à Política de Privacidade do <strong>Calcula Fácil. Valorizamos sua privacidade e queremos esclarecer como os dados são tratados ao utilizar nosso site."},
        new Pagina { Titulo = "Termo de Uso", Link="/termos-de-uso", Conteudo="Página falando sobre os termos de uso geral do site."}
    };

    public static Task<List<Pagina>> ObterIndiceAsync()
    {
        return Task.FromResult(IndicePaginas.ToList());
    }

    public static Task AdicionarPaginaAsync(Pagina pagina)
    {
        IndicePaginas.Add(pagina);
        return Task.CompletedTask;
    }
}
