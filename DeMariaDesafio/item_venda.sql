-- Table: public.item_venda

-- DROP TABLE IF EXISTS public.item_venda;

CREATE TABLE IF NOT EXISTS public.item_venda
(
    id integer NOT NULL DEFAULT nextval('item_venda_id_seq'::regclass),
    id_venda integer NOT NULL,
    id_produto integer NOT NULL,
    quantidade integer NOT NULL,
    preco_unitario numeric(10,2) NOT NULL,
    preco_total numeric(10,2) NOT NULL,
    CONSTRAINT item_venda_pkey PRIMARY KEY (id),
    CONSTRAINT fk_item_venda_produto FOREIGN KEY (id_produto)
        REFERENCES public.produto (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_item_venda_venda FOREIGN KEY (id_venda)
        REFERENCES public.venda (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.item_venda
    OWNER to postgres;

COMMENT ON TABLE public.item_venda
    IS 'Tabela de itens de venda';

COMMENT ON COLUMN public.item_venda.id
    IS 'ID do item de venda, chave primária';

COMMENT ON COLUMN public.item_venda.id_venda
    IS 'ID da venda, chave estrangeira';

COMMENT ON COLUMN public.item_venda.id_produto
    IS 'ID do produto, chave estrangeira';

COMMENT ON COLUMN public.item_venda.quantidade
    IS 'Quantidade do produto vendido';

COMMENT ON COLUMN public.item_venda.preco_unitario
    IS 'Preço unitário do produto no momento da venda';

COMMENT ON COLUMN public.item_venda.preco_total
    IS 'Preço total do item (quantidade * preço_unitário)';
-- Index: idx_item_venda_produto_id

-- DROP INDEX IF EXISTS public.idx_item_venda_produto_id;

CREATE INDEX IF NOT EXISTS idx_item_venda_produto_id
    ON public.item_venda USING btree
    (id_produto ASC NULLS LAST)
    TABLESPACE pg_default;
-- Index: idx_item_venda_venda_id

-- DROP INDEX IF EXISTS public.idx_item_venda_venda_id;

CREATE INDEX IF NOT EXISTS idx_item_venda_venda_id
    ON public.item_venda USING btree
    (id_venda ASC NULLS LAST)
    TABLESPACE pg_default;