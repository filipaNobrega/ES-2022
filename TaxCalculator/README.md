# Problema

Uma agência de cobrança de impostos tornou-se famosa por permitir adaptar métodos de cobrança de impostos de forma muito flexível. Os contribuintes (TaxPayer) são pessoas (`Employee`), empresas (`Company`) e regiões (`Region`). As pessoas trabalham nas empresas e as empresas estão sediadas em regiões. Todos têm rendimentos (as pessoas e as regiões a partir das empresas e as empresas a partir de pessoas, regiões e outras empresas) e todos devem pagar os seus impostos.

O sucesso da agência advém da facilidade com que cria variações do seu produto, o premiado `FriendlyIrs`. Estas aplicações permitem interrogar cada contribuinte de forma adaptada, tanto ao contribuinte, como à situação de cobrança desejada.

Assim, além da cobrança em habitual, através do seu produto `VanillaTaxes`, permite ainda cobrar menos impostos se o rendimento for menor que um dado valor ou se a população (número de contribuintes numa empresa ou numa região) for inferior a um dado valor de referência. Para isso, disponibiliza o seu produto `BecauseWeCare`.

- A versão implementada por `VanillaTaxes` funciona por cobrança acumulada. Cada pessoa paga uma unidade monetária e cada empresa paga o equivalente à soma das contribuições individuais dos seus empregados. Cada região paga o equivalente à soma das contribuições das empresas nela sediadas.

- A versão implementada por `BecauseWeCare` é como a anterior, mas considera ainda se o rendimento apurado é inferior a limiares de referência (BecauseWeCare.Low, para o rendimento mínimo, mas apenas para pessoas e empresas; e BecauseWeCare.Pop, para a população mínima, apenas para regiões), aplicando desconto de 10% se se verificar algum limiar.

Implemente todas as classes mencionadas.