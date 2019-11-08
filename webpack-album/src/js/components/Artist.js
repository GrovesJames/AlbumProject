export default function Artist(artists) {
    return `
    <ul> 
    ${artists
      .map(artistEDIT => {
        return `
             <li id="artist">
                <img src=${artistEDIT.image}></img>
                <h3>${artistEDIT.name}</h3>
                <h5>Age: ${artistEDIT.age}</h5>
                <h5>Hometown: ${artistEDIT.hometown}</h5>
                <p><input class="artist__id" type="hidden" value="${artistEDIT.id}"></p>
                <button class="edit-artist__submit">Edit</button>
                <button class="delete-artist__submit">Delete</button>
                </li>
                <div id="EDArtist">
                  <button class="edit-artist__submit">Edit</button>
                  <button class="delete-artist__submit">Delete</button>
                </div>
        `;
      })  
      .join("")}
 </ul>
 
<section class='add-artist'>
    <input class='add-artist_artistName' type='text' placeholder='Add A New Artist!'>
    <input class='add-artist_artistAge' type='text' placeholder='Add An Artist Age!'>
    <input class='add-artist_artistHome' type='text' placeholder='Add An Artist Hometown!'>
    <button class='add-artist_submit'>Submit</button>
</section>
    `;
}