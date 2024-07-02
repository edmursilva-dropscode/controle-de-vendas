-- Table: public.cliente

-- DROP TABLE IF EXISTS public.cliente;

CREATE TABLE IF NOT EXISTS public.cliente
(
    id integer NOT NULL DEFAULT nextval('cliente_id_seq'::regclass),
    nome character varying(255) COLLATE pg_catalog."default" NOT NULL,
    endereco character varying(255) COLLATE pg_catalog."default",
    telefone character varying(50) COLLATE pg_catalog."default",
    email character varying(255) COLLATE pg_catalog."default",
    data_cadastro timestamp without time zone DEFAULT now(),
    ativo boolean DEFAULT true,
    CONSTRAINT cliente_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.cliente
    OWNER to postgres;

COMMENT ON TABLE public.cliente
    IS 'Tabela de clientes';

COMMENT ON COLUMN public.cliente.id
    IS 'ID do cliente, chave primária';

COMMENT ON COLUMN public.cliente.nome
    IS 'Nome do cliente';

COMMENT ON COLUMN public.cliente.endereco
    IS 'Endereço do cliente';

COMMENT ON COLUMN public.cliente.telefone
    IS 'Telefone do cliente';

COMMENT ON COLUMN public.cliente.email
    IS 'Email do cliente';

COMMENT ON COLUMN public.cliente.data_cadastro
    IS 'Data de cadastro do cliente, padrão é a data e hora atual';

COMMENT ON COLUMN public.cliente.ativo
    IS 'Indica se o cliente está ativo';
-- Index: idx_cliente_nome

-- DROP INDEX IF EXISTS public.idx_cliente_nome;

CREATE INDEX IF NOT EXISTS idx_cliente_nome
    ON public.cliente USING btree
    (nome COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;