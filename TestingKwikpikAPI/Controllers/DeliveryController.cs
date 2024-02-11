using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Application.ErrorRepo;
using TestingKwikpikAPI.Application.Interfaces;
using TestingKwikpikAPI.Domain.Entities.BatchRequest;
using TestingKwikpikAPI.Domain.Entities.BatchRequestConfirmation;
using TestingKwikpikAPI.Domain.Entities.CreateSingleRequest;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IHomeAPI homeAPI;
        private readonly IAuthenticateAPI authenticateAPI;
        private readonly IWalletAPI walletAPI;
        private readonly ICreateSingleRequestAPI createSingleRequestAPI;
        private readonly IConfirmSingleRequestAPI confirmSingleRequestAPI;
        private readonly IBatchRequestAPI batchRequestAPI;
        private readonly IBatchRequestConfirmationAPI batchRequestConfirmationAPI;
        private readonly IGetDispatchRequestAPI getDispatchRequest;

        public DeliveryController(IHomeAPI homeAPI,
                                  IAuthenticateAPI authenticateAPI,
                                  IWalletAPI walletAPI,
                                  ICreateSingleRequestAPI createSingleRequestAPI,
                                  IConfirmSingleRequestAPI confirmSingleRequestAPI,
                                  IBatchRequestAPI batchRequestAPI,
                                  IBatchRequestConfirmationAPI batchRequestConfirmationAPI,
                                  IGetDispatchRequestAPI getDispatchRequest)
        {
            this.homeAPI = homeAPI;
            this.authenticateAPI = authenticateAPI;
            this.walletAPI = walletAPI;
            this.createSingleRequestAPI = createSingleRequestAPI;
            this.confirmSingleRequestAPI = confirmSingleRequestAPI;
            this.batchRequestAPI = batchRequestAPI;
            this.batchRequestConfirmationAPI = batchRequestConfirmationAPI;
            this.getDispatchRequest = getDispatchRequest;
        }

        #region GET WELCOME MESSAGE
        /// <summary>
        /// Gets the welcome message 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetWelcomeMessage()
        {
            try
            {
                var message = await homeAPI.GetMessage();
                return Ok(message);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region AUTHENTICATE A USER
        /// <summary>
        /// Checks if the user has been authenticated
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUserAuthentication()
        {
            try
            {
                var response = await authenticateAPI.GetAuthentication();
                return Ok(response);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region USER WALLET DETAILS
        /// <summary>
        /// Gets the wallet details of a user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUserWallet()
        {
            try
            {
                var response = await walletAPI.GetWalletDetails();
                return Ok(response);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region CREATE DISPATCH REQUEST
        /// <summary>
        /// Creates a dispatch for a user
        /// </summary>
        /// <param name="CreateSingleRequestDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateSingleRequest(CreateSingleRequest CreateSingleRequestDTO)
        {
            try
            {
                var response = await createSingleRequestAPI.CreateSingleRequest(CreateSingleRequestDTO);
                return Ok(response);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region CONFIRM DISPATCH REQUEST
        /// <summary>
        /// Confirms the dispatch created
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        [HttpPost("requestId")]
        public async Task<IActionResult> ConfirmSingleRequest(string requestId)
        {
            try
            {
                var response = await confirmSingleRequestAPI.ConfirmSingleRequest(requestId);
                return Ok(response);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region GET DISPATCH REQUEST
        /// <summary>
        /// Gets a specific dispatch request with the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async Task<IActionResult> GetDispatchRequest(string id)
        {
            try
            {
                var response = await getDispatchRequest.GetDispatchRequest(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region CREATE BATCH REQUEST
        /// <summary>
        /// Creates a batch request
        /// </summary>
        /// <param name="createBatch"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBatchRequest(BatchRequest createBatch)
        {
            try
            {
                var response = await batchRequestAPI.CreateBatchRequest(createBatch);
                return Ok(response);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion

        #region CONFIRM BATCH REQUEST
        /// <summary>
        /// Confirms the batch request just created
        /// </summary>
        /// <param name="confirmBatchRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ConfirmBatch(BatchRequestConfirmation confirmBatchRequest)
        {
            try
            {
                var result = await batchRequestConfirmationAPI.ConfirmBatchRequest(confirmBatchRequest);
                return Ok(result);
            }
            catch (Exception e)
            {
                return (IActionResult)ErrorAPI.GetErrorMessage(e.Message);
            }
        }
        #endregion
    }
}
