<template>
  <div class="w-100 h-100 d-flex flex-row flex-wrap ga-5 justify-center align-center p-5 my-5">
    <div class="w-75 d-flex flex-row flex-wrap justify-start align-center">
      <div v-for="item in sites" class=" flex-grow-0 flex-shrink-0 position-relative" style="flex-basis: 20%;"
        :key="item.Name">
        <div class="position-relative" style="margin-bottom: 100%;" :key="item.Name">



        </div>
        <div class="position-absolute w-100 h-100 top-0 left-0 pa-2">
          <a :href="item.Path" class="h-100">
            <v-card :variant="variant" class="mx-auto h-100 d-flex flex-row flex-wrap ga-5 justify-center align-center"
              color="surface-variant">
              <div class="text-center px-5 ">
                {{ item.Name }}
              </div>
            </v-card>
          </a>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
  data: function () {

    return {
      sites: [
        {
          Name: "Avansna faktura",
          Path: ""
        },
        {
          Name: "Faktura sa oslobođenjem PDV-a",
          Path: ""
        },
        {
          Name: "Faktura za javnu nabavku",
          Path: ""
        },
        {
          Name: "Faktura",
          Path: ""
        },
        {
          Name: "Dokument o smanjenju",
          Path: ""
        },
        {
          Name: "Dokument o povećanju",
          Path: ""
        },
        {
          Name: "Konačna faktura",
          Path: ""
        },
        {
          Name: "Dokument o smanjenju u periodu",
          Path: ""
        },
        {
          Name: "Dokument o smanjenju za više faktura",
          Path: ""
        },
        {
          Name: "Faktura sa prilogom",
          Path: ""
        },
        {
          Name: "Faktura sa popustima",
          Path: ""
        },
        {
          Name: "Faktura sa anuliranjem",
          Path: ""
        },
        {
          Name: "Faktura sa valutom",
          Path: ""
        },
        {
          Name: "Konačna faktura sa valutom",
          Path: ""
        },
        {
          Name: "Dokument o smanjenju po osnovu smanjenja avansa",
          Path: ""
        },
        {
          Name: "Fiskalizacija promet-prodaja",
          Path: ""
        },
        {
          Name: "Fiskalizacija promet-refundacija",
          Path: ""
        }
      ]

    }
  }
}
</script>