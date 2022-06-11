<template>
  <div>
    <h1 class="mt-5 pt-1 pb-1">{{ product.title }}</h1>
    <b-row>
      <b-col sm="9" class="pr-1 pt-2"
        ><img
          :src="product.image.src"
          class="
            img-fluid
            ${3|rounded-top,rounded-right,rounded-bottom,rounded-left,rounded-circle,|}
          "
          alt=""
      /></b-col>
      <b-col class="pl-1 pt-2" sm="3">
        <div class="text-left pl-2 mr-2" id="right-details">
          <p>{{ product.description }}</p>
          <p class="mt-2">
            Rating: {{ product.rating }}
            <b-icon
              v-if="star1"
              class="ml-2 filled-star"
              icon="star-fill"
              font-scale="1"
            ></b-icon>
            <b-icon v-else icon="star" font-scale="1"></b-icon>
            <b-icon
              v-if="star2"
              class="filled-star"
              icon="star-fill"
              font-scale="1"
            ></b-icon>
            <b-icon v-else icon="star" font-scale="1"></b-icon>
            <b-icon
              v-if="star3"
              class="filled-star"
              icon="star-fill"
              font-scale="1"
            ></b-icon>
            <b-icon v-else icon="star" font-scale="1"></b-icon>
            <b-icon
              v-if="star4"
              class="filled-star"
              icon="star-fill"
              font-scale="1"
            ></b-icon>
            <b-icon v-else icon="star" font-scale="1"></b-icon>
            <b-icon
              v-if="star5"
              class="filled-star"
              icon="star-fill"
              font-scale="1"
            ></b-icon>
            <b-icon v-else icon="star" font-scale="1"></b-icon>
          </p>
          <p class="mt-1">Price: {{ formattedPrice }}</p>
          <button class="mt-5 mb-2 add-to-cart-button">Add To Cart</button>
          <p class="mt-5">Shipping stuff</p>
          <p class="mt-5">More Options</p>
        </div>
      </b-col>
    </b-row>
  </div>
</template>
<script>
import ProductService from "@/api-services/product-service.js";
const currencyFormatter = new Intl.NumberFormat("en-US", {
    currency: 'USD',
    style: 'currency',
    minimumFractionDigits: 2
});
export default {
  data() {
    return {
      productId: 0,
      product: {},
      star1: false,
      star2: false,
      star3: false,
      star4: false,
      star5: false,
    };
  },
  computed:{
      formattedPrice: function(){
          return currencyFormatter.format(this.product.price);
      }
  },
  methods: {
    getProductDetails() {
      console.log(this.productId);
      ProductService.get(this.productId).then((response) => {
        this.product = response.data;
        if (this.product.rating < 1) {
          return;
        }
        if (this.product.rating >= 1) {
          this.star1 = true;
        }
        if (this.product.rating >= 2) {
          this.star2 = true;
        }
        if (this.product.rating >= 3) {
          this.star3 = true;
        }
        if (this.product.rating >= 4) {
          this.star4 = true;
        }
        if (this.product.rating >= 5) {
          this.star5 = true;
        }
      });
    },
  },
  mounted() {
    this.productId = this.$route.params.productId;
    this.getProductDetails();
  },
};
</script>
<style>
.filled-star {
  color: orange;
}

#right-details {
  border: black 1px;
  box-shadow: rgba(0, 0, 0, 0.16) 0px 10px 36px 0px,
    rgba(0, 0, 0, 0.06) 0px 0px 0px 1px;
  border-radius: 15px;
  height: 100%;
}

.add-to-cart-button {
  background-image: linear-gradient(144deg, #00ffb3, #9ae60e 50%, #00ffb3);
  border: 0;
  border-radius: 8px;
  box-shadow: rgba(151, 65, 252, 0.2) 0 15px 30px -5px;
  box-sizing: border-box;
  color: #ffffff;
  font-family: Phantomsans, sans-serif;
  font-size: 20px;
  line-height: 1em;
  max-width: 100%;
  min-width: 140px;
  padding: 19px 24px;
  text-decoration: none;
  user-select: none;
  -webkit-user-select: none;
  touch-action: manipulation;
  white-space: nowrap;
  cursor: pointer;
}

.add-to-cart-button:active,
.add-to-cart-button:hover {
  outline: 0;
}

@media (min-width: 768px) {
  .add-to-cart-button {
    font-size: 24px;
    min-width: 196px;
  }
}
</style>