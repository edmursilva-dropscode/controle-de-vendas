-- Table: public.venda

-- DROP TABLE IF EXISTS public.venda;

CREATE TABLE IF NOT EXISTS public.venda
(
    id integer NOT NULL DEFAULT nextval('venda_id_seq'::regclass),
    id_cliente integer NOT NULL,
    data timestamp without time zone NOT NULL,
    total numeric(10,2) NOT NULL,
    id_status integer NOT NULL,
    observacao text COLLATE pg_catalog."default",
    CONSTRAINT venda_pkey PRIMARY KEY (id),
    CONSTRAINT fk_cliente FOREIGN KEY (id_cliente)
        REFERENCES public.cliente (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.venda
    OWNER to postgres;

COMMENT ON TABLE public.venda
    IS 'Tabela de vendas';

COMMENT ON COLUMN public.venda.id
    IS 'ID da venda, chave primária';

COMMENT ON COLUMN public.venda.id_cliente
    IS 'ID do cliente, chave estrangeira referenciando cliente(id)';

COMMENT ON COLUMN public.venda.data
    IS 'Data e hora da venda';

COMMENT ON COLUMN public.venda.total
    IS 'Valor total da venda';

COMMENT ON COLUMN public.venda.id_status
    IS 'Status da venda (por exemplo, 1 - pendente, 2 - concluída)';

COMMENT ON COLUMN public.venda.observacao
    IS 'Observações adicionais sobre a venda';
-- Index: idx_venda_data_venda

-- DROP INDEX IF EXISTS public.idx_venda_data_venda;

CREATE INDEX IF NOT EXISTS idx_venda_data_venda
    ON public.venda USING btree
    (data ASC NULLS LAST)
    TABLESPACE pg_default;
-- Index: idx_venda_id_cliente

-- DROP INDEX IF EXISTS public.idx_venda_id_cliente;

CREATE INDEX IF NOT EXISTS idx_venda_id_cliente
    ON public.venda USING btree
    (id_cliente ASC NULLS LAST)
    TABLESPACE pg_default;