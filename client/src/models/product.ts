import { ProductImage } from "./ProductImage";
import { Option } from "./Option"
import { Variant } from "./Variant";

export interface Product {
    id: number;
    title: string;
    body_html: string;
    vendor: string;
    product_type: string;
    created_at: string;
    handle: string;
    updated_at: string;
    published_at: any;
    template_suffix: string;
    status: string;
    published_scope: string;
    tags: string;
    admin_graphql_api_id: string;
    variants: Variant[];
    options: Option[];
    images: ProductImage[];
    image: ProductImage;
}