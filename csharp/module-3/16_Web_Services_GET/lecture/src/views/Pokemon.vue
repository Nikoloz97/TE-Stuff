<template>
  <div>
      <input id="pokemonInput" type="text" v-model="name"/>
      <button v-on:click="findPokemon">Click Here</button>

      <br><br>
      <h1>{{pokemon.name}}</h1>
      <div v-for="stat in pokemon.stats" v-bind:key="stat">
        <p>base stat: {{stat.base_stat}}</p>
        <p>effort: {{stat.effort}}</p>
        <p>name: {{stat.stat.name}}</p>
      </div>
  </div>
</template>

<script>
import pokemonService from '../services/PokemonService.js';

export default {
    name: 'pokemon',
    data()  {
        return {
            name: '',
            pokemon: {}
        }
    },
    methods: {
        findPokemon() {
            pokemonService.getPokemon(this.name).then((response) => {
                this.pokemon = response.data;
            })
        }
    }

}
</script>

<style>

</style>