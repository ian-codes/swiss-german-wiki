<script lang="ts">
    import Filter from "./Filter.svelte";

    let filterItems: Array<string> = ["trending", "recent", "top"]

    let activeFilter: string = "trending";
</script>


<div class="container">
    {#each filterItems as item}
        <Filter item={item} bind:activeFilter={activeFilter} />
    {/each}
</div>


<style>
    .container {
        display: flex;
        flex-direction: row;
        align-items: center;
        justify-content: center;
        gap: 1em;
        margin: 1em 0;
    }
</style>