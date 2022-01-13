<template>
    <div>
        <b-row>
            <b-col sm="9" class="pr-1"><img src="https://production-livingdocs-bluewin-ch.imgix.net/2019/8/23/d6ca0619-9260-497b-a6ad-88bf0aad83b8.jpeg?w=1024&auto=format" class="img-fluid ${3|rounded-top,rounded-right,rounded-bottom,rounded-left,rounded-circle,|}" alt=""></b-col>
            <b-col class="pl-1" sm="3">
                <h1>{{ product.title }}</h1>
                <p>{{ product.Description }}</p>
                <p>{{ product.price }}</p>
                <p>{{ product.rating }}</p>
            </b-col>
        </b-row>
    </div>
</template>
<script>
import ProductService from "@/api-services/product-service.js";

export default {
    data() {
        return {
            productId: 0,
            product: {}
        }
    },
    methods: {
        getProductDetails(){
            console.log(this.productId);
            ProductService.get(this.productId).then((response) =>{
                this.product = response.data;
            });
        }
    },
    mounted() {
        this.productId = this.$route.params.productId;
        this.getProductDetails();
    },
}
</script>
<style>
    
</style>