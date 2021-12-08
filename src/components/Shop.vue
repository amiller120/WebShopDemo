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
                img-src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fd.newsweek.com%2Fen%2Ffull%2F1119776%2Fgettyimages-159044749.jpg&f=1&nofb=1"
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