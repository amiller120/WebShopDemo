<template>
    <div class="create-new-product-form">
        <b-container>
            <b-card>
                <b-form>
                    <b-card>
                        <b-form-group id="titleInputGroup"
                                    label="Product Title:"
                                    label-for="title-input"
                                    description="Give a name to your new product">
                            <b-form-input id="title-input"
                                        v-model="product.title"
                                        placeholder="Enter title..."
                                        required>
                            </b-form-input>
                        </b-form-group>
                    </b-card>

                    <b-form-group id="descriptionInputGroup"
                                label="Product Description:"
                                label-for="description-input"
                                description="What could you say to describe this new product?">
                        <b-form-input id="description-input"
                                    v-model="product.body_html"
                                    placeholder="Enter a description..."
                                    required>
                        </b-form-input>
                    </b-form-group>

                    <b-form-group id="productTypeGroup"
                                label="Type of Product:"
                                label-for="product-type-input"
                                description="What kind of product is this?">
                        <b-form-input id="product-type-input"
                                    v-model="product.product_type"
                                    placeholder="Enter the product type..."
                                    required>
                        </b-form-input>
                    </b-form-group>

                    <b-form-group id="productVendorGroup"
                                label="Product's Vendor:"
                                label-for="product-vendor-input"
                                description="Who is the vendor for this product?">
                        <b-form-input id="product-vendor-input"
                                    v-model="product.vendor"
                                    placeholder="Enter the product vendor..."
                                    required>
                        </b-form-input>
                    </b-form-group>
                </b-form>
            </b-card>
        </b-container>
    </div>
</template>

<script>
    // import ProductService from "@/api-services/product-service.js";

    export default {
        data() {
            return {
                product: {
                    type: Object

                }
            }
        },
        methods: {

        }
    }
</script>

<style scoped>
</style>