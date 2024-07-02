-- Table: public.produto

-- DROP TABLE IF EXISTS public.produto;

CREATE TABLE IF NOT EXISTS public.produto
(
    id integer NOT NULL DEFAULT nextval('produto_id_seq'::regclass),
    descricao character varying(255) COLLATE pg_catalog."default" NOT NULL,
    preco numeric(10,2) NOT NULL,
    quantidade integer NOT NULL,
    data_cadastro timestamp without time zone DEFAULT now(),
    ativo boolean DEFAULT true,
    CONSTRAINT produto_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.produto
    OWNER to postgres;

COMMENT ON TABLE public.produto
    IS 'Tabela de produtos';

COMMENT ON COLUMN public.produto.id
    IS 'ID do produto, chave primária';

COMMENT ON COLUMN public.produto.descricao
    IS 'Descrição do produto';

COMMENT ON COLUMN public.produto.preco
    IS 'Preço do produto';

COMMENT ON COLUMN public.produto.quantidade
    IS 'Quantidade em estoque';

COMMENT ON COLUMN public.produto.data_cadastro
    IS 'Data de cadastro do produto, padrão é a data e hora atual';

COMMENT ON COLUMN public.produto.ativo
    IS 'Indica se o produto está ativo';
-- Index: idx_produto_descricao

-- DROP INDEX IF EXISTS public.idx_produto_descricao;

CREATE INDEX IF NOT EXISTS idx_produto_descricao
    ON public.produto USING btree
    (descricao COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;