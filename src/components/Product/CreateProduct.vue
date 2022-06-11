<template>
  <div>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">
      <b-form-group
        id="input-group-1"
        label="Title:"
        label-for="input-1"
        description="Title for the product."
      >
        <b-form-input
          id="input-1"
          v-model="form.title"
          type="text"
          placeholder="Enter Title"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2" label="Your Name:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="form.body_html"
          placeholder="Body Html"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3" label="Status:" label-for="input-3">
        <b-form-select
          id="input-3"
          v-model="form.status"
          :options="statuses"
          required
        ></b-form-select>
      </b-form-group>

      <b-form-group id="input-group-4" label="Product Type:" label-for="input-4">
        <b-form-input
          id="input-4"
          v-model="form.product_type"
          placeholder="Product Type"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-5" label="Tags:" label-for="input-5">
        <b-form-input
          id="input-5"
          v-model="form.tags"
          placeholder="tags"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-6" label="Upload Image:" label-for="input-6">
        <b-form-file
      v-model="form.image"
      placeholder="Choose a file or drop it here..."
      drop-placeholder="Drop file here..."
    ></b-form-file>
      </b-form-group>


      <b-button type="submit" variant="primary">Submit</b-button>
      <b-button type="reset" variant="danger">Reset</b-button>
    </b-form>
    <b-card class="mt-3" header="Form Data Result">
      <pre class="m-0">{{ form }}</pre>
    </b-card>
  </div>
</template>

<script>
  import ProductService from "../../api-services/product-service"

  export default {
    data() {
      return {
        form: {
          title: '',
          body_html: '',
          product_type: '',
          tags: '',
          image: null,
          status: ''
        },
        statuses: [{ text: 'Select One', value: null }, 'active', 'draft', 'archived'],
        show: true
      }
    },
    methods: {
      onSubmit(event) {
        event.preventDefault()
        var formData = new FormData();
        formData.append("title", this.form.title);
        formData.append("body_html", this.form.body_html);
        formData.append("product_type", this.form.product_type);
        formData.append("tags", this.form.tags);
        formData.append("image", this.form.image);
        formData.append("status", this.form.status);
        ProductService.create(formData).then((response) =>  {
            console.log(response);
        })
        .catch((error) => 
        {
            console.error(error);
        });
      },
      onReset(event) {
        event.preventDefault()
        // Reset our form values
        // Trick to reset/clear native browser form validation state
        this.show = false
        this.$nextTick(() => {
          this.show = true
        })
      }
    }
  }
</script>