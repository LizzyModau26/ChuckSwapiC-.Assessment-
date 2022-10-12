import Table from 'react-bootstrap/Table';
import useAxios from 'axios-hooks';
import "../../assets/css/swapi.css";

const style = {
    backgroundImage: 'url("/background.jpg")',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    backgroundRepeat: 'no-repeat',
    width: '100vw',
    height: '100vh',
}


const RenderUserInfo = (props) => {
    const { name, height, mass, homeworld } = props;
    return (
        <div >
            <Table striped bordered hover>
                <tbody>
                    <tr>
                        <td>{name}</td>
                        <td>{height}</td>
                        <td>{mass}</td>
                        <td>{homeworld}</td>
                    </tr>
                </tbody>
            </Table>

        </div>
    );
};

//
function Swapi() {

    const [{ data, loading, error }, refetch] = useAxios(
        'swapi/people'
    )

    if (loading) return <p>Loading...</p>
    if (error) return <p>Error!</p>

    return (

        <div>
            <h1 className='font-link'>List Of Awesome Star Wars Characters</h1>
            {data &&
                !error &&
                !loading &&
                data.results.map((item, index) => (

                    <RenderUserInfo
                        name={item.name}
                        height={item.height}
                        mass={item.mass}
                        homeworld={item.homeworld}
                        key={index}
                    />
                ))}
            {loading && <p>Loading ...</p>}
            {error && (<p>{error.message}</p>)}
        </div>
    )
}
export default Swapi