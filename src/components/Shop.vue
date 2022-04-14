<template>
  <div>
    <b-container>
      <h1>Shop Page</h1>
      <b-row>
        
            <b-card-group columns>
        <div
          class="card column is-one-quarter"
          v-for="product in products"
          :key="product.id"
        >
          <b-col>
              <b-card
                img-src="product.image"
                img-alt="Image"
                img-top
              >
              <b-card-body style="min-height:20rem;">
                <VProducts :product="product"></VProducts>
                </b-card-body>
                <b-card-footer style="padding: 0px">
                  Last updated 3 mins ago
                </b-card-footer>
              </b-card>
          </b-col>

        </div>
            </b-card-group>
          
      </b-row>
    </b-container>
  </div>
</template>
<script>

import VProducts from "../components/Product/Product.vue";
import ProductService from "@/api-services/product-service.js";

export default {
  components: { VProducts },
  data() {
    return {
      products: [],
    };
  },
  created(){
    ProductService.getAll().then((response) => {
      this.products = response.data;
    });
  }
};
</script>
<style>
</style>